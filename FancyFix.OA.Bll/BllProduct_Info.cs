﻿using Dos.DataAccess.Base;
using Dos.ORM;
using FancyFix.OA.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FancyFix.OA.Bll
{
    public class BllProduct_Info : ServiceBase<Product_Info>
    {
        public static BllProduct_Info Instance()
        {
            return new BllProduct_Info();
        }

        #region 后台方法

        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="title"></param>
        /// <param name="classId"></param>
        /// <param name="prono"></param>
        /// <param name="onlypar"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="records"></param>
        /// <returns></returns>
        public static List<Product_Info> PageList(string title, string classParPath, string sku, int page, int pageSize, out long records)
        {
            var where = new Where<Product_Info>();
            if (!string.IsNullOrEmpty(title))
                where.And(Product_Info._.Title.Like(title));
            if (!string.IsNullOrEmpty(classParPath) && classParPath != "0")
                where.And(Product_Info._.ClassParPath.BeginWith(classParPath));
            if (!string.IsNullOrEmpty(sku))
                where.And(Product_Info._.Sku.BeginWith(sku));

            var p = Db.Context.From<Product_Info>()
                 .Select<Mng_User>((a, b) => new { a.Id, a.Title, a.Color, a.Spu, a.Sku, a.FirstPic, a.Moq, a.QuantityUnit, a.AdminId, a.IsShow, a.CreateDate, a.Url, a.Stock, b.RealName })
                 .LeftJoin<Mng_User>((a, b) => a.AdminId == b.Id)
                 .Where(where);

            records = p.Count();
            return p.Page(pageSize, page).OrderByDescending(o => o.Id).ToList();
        }

        /// <summary>
        /// 是否存在同编号产品
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public static bool IsExists(string sku)
        {
            return Any(o => o.Sku == CheckSqlKeyword(sku));
        }

        /// <summary>
        /// 更新产品图片
        /// </summary>
        /// <param name="proId"></param>
        /// <param name="firstPic"></param>
        /// <param name="pics"></param>
        /// <returns></returns>
        public static bool UpdateProImgs(int proId, string firstPic, string pics)
        {
            if (proId == 0) return false;
            return Update(new Product_Info { FirstPic = firstPic, Pics = pics }, o => o.Id == proId) > 0;
        }

        /// <summary>
        /// 更新产品详情内容图片
        /// </summary>
        /// <param name="proId"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public static bool UpdateDetailImgs(int proId, string content)
        {
            if (proId == 0) return false;
            return Update(new Product_Info { Content = content }, o => o.Id == proId) > 0;
        }

        /// <summary>
        /// 设置显隐
        /// </summary>
        /// <param name="proId"></param>
        /// <returns></returns>
        public static bool SetShow(int proId)
        {
            if (proId == 0) return false;
            var model = FirstSelect(o => o.Id == proId, o => new { o.Id, o.IsShow });
            if (model == null || model.Id == 0) return false;

            model.IsShow = !model.IsShow;
            return Update(model, o => o.Id == model.Id) > 0;
        }

        /// <summary>
        /// 批量删除父子产品
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static bool DeleteAllBatch(List<Product_Info> list)
        {
            if (list == null && list.Count == 0) return false;
            try
            {
                using (var trans = Db.Context.BeginTransaction())
                {
                    int count = 0;
                    foreach (var item in list)
                    {
                        count = trans.Delete<Product_Info>(o => o.Id == item.Id);
                    }
                    trans.Commit();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Tools.Tool.LogHelper.WriteLog(ex);
                return false;
            }
        }

        #endregion
    }
}
