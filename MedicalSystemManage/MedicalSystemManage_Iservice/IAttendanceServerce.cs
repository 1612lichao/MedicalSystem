﻿using System;
using System.Collections.Generic;
using System.Text;

using MedicalSystemManage.Model;

namespace MedicalSystemManage.MedicalSystemManage_Iservice
{
    /// <summary>
    /// 考勤统计
    /// </summary>
    public interface IAttendanceServerce
    {
        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        PageModel<Attendance> GetAttendance(int pageIndex = 1, int pageSize = 3);

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="crewscheduling"></param>
        /// <returns></returns>
        int AddAttendance(Attendance attendance);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="crewscheduling"></param>
        /// <returns></returns>
        int EditAttendance(Attendance attendance);

        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Attendance GetModel(int id);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DeleteAttendance(int id);
    }
}
