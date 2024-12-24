﻿using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ya.Model
{
    [SugarTable("recipe")]
    public class RecipeEntity : BaseEntity
    {
        [SugarColumn(ColumnDataType = "Nvarchar(255)", IsNullable = false)] //设置字段类型和不能为空
        public string 产品类型 { get; set; }

        public string 脱脂设定压力上限值 { get; set; } = string.Empty;
        public string 脱脂设定压力下限值 { get; set; } = string.Empty;

        public string 粗洗喷淋泵过载上限值 { get; set; } = string.Empty;

        public string 粗洗液位下限值 { get; set; } = string.Empty;

        public string 陶化喷淋泵过载上限值 { get; set; } = string.Empty;

        public string 精洗喷淋泵过载上限值 { get; set; } = string.Empty;

        public string 精洗液位下限值 { get; set; } = string.Empty;


        public string 水分炉温度上限值 { get; set; } = string.Empty;

        public string 水分炉温度下限值 { get; set; } = string.Empty;

        public string 冷却室离心风机过载上限值 { get; set; } = string.Empty;

        public string 固化炉温度上限值 { get; set; } = string.Empty;

        public string 固化炉温度下限值 { get; set; } = string.Empty;

        public string 输送机设定速度 { get; set; } = string.Empty;

        public string 输送机设定频率 { get; set; } = string.Empty;
    }
}
