using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using MedicalSystemManage.Model;
namespace MedicalSystemManage_Model
{
   public class BaseDbContext: DbContext
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("Data Source=169.254.139.102;Initial Catalog=hospital;User ID=root;pwd=123456");
            }
        }

        /// <summary>
        /// 消息公布
        /// </summary>
        public DbSet<Announcementform> AnnouncementformModel { get; set; }
}
}
