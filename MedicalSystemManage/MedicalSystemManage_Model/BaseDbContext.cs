using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using MedicalSystemManage.Model;
namespace MedicalSystemManage_Model
{
   public class BaseDbContext: DbContext
    {
        /// <summary>
        /// 消息公布
        /// </summary>
        public DbSet<Announcementform> AnnouncementformModel { get; set; }
}
}
