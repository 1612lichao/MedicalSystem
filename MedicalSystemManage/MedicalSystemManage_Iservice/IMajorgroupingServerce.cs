﻿using System;
using System.Collections.Generic;
using System.Text;


using MedicalSystemManage.Model;
using System.Data;

namespace MedicalSystemManage.MedicalSystemManage_Iservice
{
    /// <summary>
    /// 专业分组设置
    /// </summary>
    public interface IMajorgroupingServerce
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="majorgrouping"></param>
        /// <returns></returns>
        int Add(IMajorgroupingServerce majorgrouping);

        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        List<IMajorgroupingServerce> GetMajorgrouping(string Name = "");

        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        IMajorgroupingServerce GetMajorgrouping(int Id);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="majorgrouping"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        int GetMajorgrouping(IMajorgroupingServerce majorgrouping, int Id);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        int DelMajorgrouping(int Id);
    }
}
