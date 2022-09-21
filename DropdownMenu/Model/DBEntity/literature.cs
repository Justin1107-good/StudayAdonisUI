using System;
using System.Collections.Generic;
using System.Text;
using SqlSugar;

namespace DropdownMenu.Model.DBEntity
{
    [SugarTable("stu_literature")]
    public class literature
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true, ColumnDescription = "主键")]//设置主键，设置自增，字段注释
        public int id { get; set; }
        [SugarColumn(ColumnDescription = "", IsNullable = false)]
        public string literatureName { get; set; }
        [SugarColumn(ColumnDescription = "", IsNullable = false)]
        public string literatureUrl { get; set; }
    }
}
