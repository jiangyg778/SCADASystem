﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ya.Model
{
    public class PLCVarConfigModel
    {
        public string 所属模块 { get; set; }

        public string 名称 { get; set; }

        public string PLC地址 { get; set; }

        public string 变量类型 { get; set; }

        public string 是否保存 { get; set; }
    }
}
