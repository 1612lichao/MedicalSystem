﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalSystemManage.Model
{
    //班次规则表
    public class ShiftRules
    {
        public int ID { get; set; }                  //ID
        public string ShiftScorise { get; set; }     //班次规则
        public int IsEffect { get; set; }            //是否生效
    }
}
