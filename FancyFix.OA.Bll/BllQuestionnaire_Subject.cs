﻿using Dos.DataAccess.Base;
using Dos.ORM;
using FancyFix.OA.Model;
using System.Collections.Generic;

namespace FancyFix.OA.Bll
{
    public class BllQuestionnaire_Subject : ServiceBase<Questionnaire_Subject>
    {
        public static BllQuestionnaire_Subject Instance()
        {
            return new BllQuestionnaire_Subject();
        }

        public static List<Questionnaire_Subject> PageList(int page, int pageSize, out long records)
        {
            var where = new Where<Questionnaire_Subject>();

            var p = Db.Context.From<Questionnaire_Subject>()
                 .Select((a) => new { a.Id, a.Title, a.Timelimit, a.Remark, a.Score, a.Sequence, a.IsShow })
                 .Where(where);

            records = p.Count();
            return p.Page(pageSize, page).OrderBy(o => o.Sequence).ToList();
        }

        public static List<Questionnaire_Subject> GetList()
        {
            var where = new Where<Questionnaire_Subject>();
            where.And(o => o.IsShow == true);
            var p = Db.Context.From<Questionnaire_Subject>()
                 .Select((a) => new { a.Id, a.Title, a.Timelimit, a.Remark, a.Score, a.Sequence, a.IsShow })
                 .Where(where);

            return p.OrderBy(o => o.Sequence).ToList();
        }

        /// <summary>
        /// 设置显隐
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool SetShow(int id)
        {
            var model = FirstSelect(o => o.Id == id, o => new { o.Id, o.IsShow });
            if (model == null && model.Id == 0) return false;

            model.IsShow = !model.IsShow;
            return Update(model, o => o.Id == model.Id) > 0;
        }

    }
}
