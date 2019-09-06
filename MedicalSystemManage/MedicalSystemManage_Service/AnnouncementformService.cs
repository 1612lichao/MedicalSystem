using MedicalSystemManage.MedicalSystemManage_Iservice;
using MedicalSystemManage.Model;
using System;
using System.Collections.Generic;
using System.Text;
using MedicalSystemManage_Model;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace MedicalSystemManage_Service
{
    public class AnnouncementformService : IAnnouncementformServerce
    {
        BaseDbContext db = new BaseDbContext();
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="announcementform"></param>
        /// <returns></returns>
        public int Add(Announcementform announcementform)
        {
            db.AnnouncementformModel.Add(announcementform);
            int i = db.SaveChanges();
            return i;
        }

        /// <summary>
        /// 显示分页
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public PageModel<Announcementform> announcementform(string Name = "", int pageIndex = 0, int pageSize = 3)
        {
            if (Name == null)
            {
                Name = "";
            }
            PageModel<Announcementform> pagemodel = new PageModel<Announcementform>();
            int totalcount = db.AnnouncementformModel.Where(m => m.ReleaseContent.Contains(Name)).ToList().Count();
            //分页
            var list = db.AnnouncementformModel.Where(m => m.ReleaseContent.Contains(Name)).ToList().Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            pagemodel.TotalCount = totalcount;
            pagemodel.Data = list;
            return pagemodel;
        }

        /// <summary>
        /// 反填
        /// </summary>
        /// <returns></returns>
        public   Announcementform Byid(int id)  
        {
          var lsit= db.AnnouncementformModel.Find(id);
            return lsit;
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Delete(int id)
        {
            var list = db.AnnouncementformModel.Find(id);
            db.AnnouncementformModel.Remove(list);
            int i = db.SaveChanges();
            return i;
        }

        /// <summary>
        ///  修改
        /// </summary>
        /// <param name="announcementform"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Update(Announcementform announcementform)
        {
            db.Entry(announcementform).State = EntityState.Modified;
            int i = db.SaveChanges();
            return i;
        }
    }
}
