﻿using System;
using System.Collections.Generic;
using System.Text;

using MedicalSystemManage.Model;

namespace MedicalSystemManage.MedicalSystemManage_Iservice
{
    /// <summary>
    /// 法定节日
    /// </summary>
    public interface IStatutoryholidayServerce
    {
        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        PageModel<Statutoryholiday> GetStatutoryholiday(int pageIndex = 1, int pageSize = 3);

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="crewscheduling"></param>
        /// <returns></returns>
        int AddStatutoryholiday(Statutoryholiday statutoryholiday);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="crewscheduling"></param>
        /// <returns></returns>
        int EditStatutoryholiday(Statutoryholiday statutoryholiday);

        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Statutoryholiday GetModel(int id);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DeleteStatutoryholiday(int id);
    }
}
