using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace DropdownMenu.Model.DBEntity
{
    [SugarTable("sky_LogInfo")]
    public class sky_LogInfo
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true, ColumnDescription = "主键")]//设置主键，设置自增，字段注释
        public int id { get; set; }
        [SugarColumn(ColumnDescription = "", IsNullable = false)]
        public string MethodName { get; set; }//方法
        [SugarColumn(ColumnDescription = "", IsNullable = false)]
        public string OperationType { get; set; }//操作类型 crud
        [SugarColumn(ColumnDescription = "", IsNullable = false)]
        public DateTime VisitDate { get; set; } //访问时间
        [SugarColumn(ColumnDescription = "", IsNullable = false)]
        public DateTime respDate { get; set; } //响应时间
        [SugarColumn(ColumnDescription = "", IsNullable = false)]
        public string userName { get; set; }//操作用户
        [SugarColumn(ColumnDescription = "", IsNullable = false)]
        public string paramsList { get; set; } //参数信息json
        [SugarColumn(ColumnDescription = "", IsNullable = false)]
        public string errorMsg { get; set; }//操作错误信息
        [SugarColumn(ColumnDescription = "", IsNullable = false)]
        public string results { get; set; } //放回jsonzifucc
    }
}
