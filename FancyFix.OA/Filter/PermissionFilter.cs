﻿using FancyFix.OA.Bll;
using FancyFix.Core.Admin;
using FancyFix.OA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace FancyFix.OA.Filter
{
    /// <summary>
    /// 权限验证全局过滤器
    /// </summary>
    public class PermissionFilter : IAuthorizationFilter
    {
        /// <summary>
        /// 验证核心
        /// </summary>
        /// <param name="httpContext"></param>
        /// <returns></returns>
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            if (filterContext == null) throw new ArgumentNullException("filterContext");
            if (filterContext.HttpContext.Request.Url == null) throw new ArgumentNullException("filterContext");

            //判断action,controller上是否存在AllowAnonymous标签
            var actionAnonymous = filterContext.ActionDescriptor.GetCustomAttributes(typeof(AllowAnonymousAttribute), true) as IEnumerable<AllowAnonymousAttribute>;
            var controllerAnonymous = filterContext.Controller.GetType().GetCustomAttributes(typeof(AllowAnonymousAttribute), true) as IEnumerable<AllowAnonymousAttribute>;
            if ((actionAnonymous != null && actionAnonymous.Any()) || (controllerAnonymous != null && controllerAnonymous.Any()))
                return;

            //当前用户
            Mng_User myInfo = new AdminState(filterContext.HttpContext).GetUserInfo();
            if (myInfo == null || !(bool)myInfo.InJob)
            {
                filterContext.Result = new RedirectToRouteResult(new System.Web.Routing.RouteValueDictionary(new { Controller = "auth", action = "login", area = "" }));
            }
            else
            {
                // 判断action,controller上是否有CheckLoginAttribute标签 只要登录就可以访问
                var checkLoginActionAttr = filterContext.ActionDescriptor.GetCustomAttributes(typeof(CheckLoginAttribute), true) as IEnumerable<CheckLoginAttribute>;
                var checkLoginControllerAttr = filterContext.Controller.GetType().GetCustomAttributes(typeof(CheckLoginAttribute), true) as IEnumerable<CheckLoginAttribute>;
                if ((checkLoginActionAttr != null && checkLoginActionAttr.Any()) || (checkLoginControllerAttr != null && checkLoginControllerAttr.Any()))
                    return;

                //如果使用了权限控制标签，则优先使用标签
                var permissionFilterAttribute = filterContext.ActionDescriptor.GetCustomAttributes(typeof(PermissionFilterAttribute), true) as IEnumerable<PermissionFilterAttribute>;
                if (permissionFilterAttribute != null && permissionFilterAttribute.Any())
                    return;

                //获取当前路由信息
                string areaName = filterContext.RouteData.DataTokens["area"]?.ToString() ?? "";
                string controllerName = filterContext.RouteData.Values["controller"].ToString();
                string actionName = filterContext.RouteData.Values["action"].ToString();

                //拼接Url
                string url = (areaName != "" ? "/" + areaName : "") + "/" + controllerName + "/" + actionName;

                //验证权限
                bool isValid = PermissionManager.CheckPermission(myInfo, url.ToLower());
                if (!isValid)
                {
                    //验证不通过
                    if (filterContext.HttpContext.Request.IsAjaxRequest())
                    {
                        filterContext.Result = new HttpUnauthorizedResult(); //Ajax请求，返回401
                    }
                    else
                    {
                        var content = new ContentResult()
                        {
                            Content = "<script type=\"text/javascript\">" +
                            "var w = parent.layer.getFrameIndex(window.name);" +
                            "var tab = parent.document.getElementsByClassName('layui-this')[0].getAttribute('lay-id');" +
                            "if(w){parent.layer.close(w);}" + //弹窗：关闭弹窗，并提示
                            "else if(tab.toLowerCase().indexOf('" + url.ToLower() + "')>=0){}" + //弹出新tab页，不做任何处理，只提示
                            "else{window.history.go(-1);};" + //直接跳转：跳会上页，并提示
                            "parent.layer.msg('您没有该操作权限！', {icon: 5});" +
                            "</script>"
                        };
                        filterContext.Result = content;// new RedirectResult("/Home/UnAuthorized");
                    }
                }
                return;
            }
        }
    }
}