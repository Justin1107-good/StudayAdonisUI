using SqlSugar;
using System;
using System.Linq;
using System.Text;

namespace DropdownMenu.Model.DBEntity
{
    ///<summary>
    ///
    ///</summary>
    ///
    [SugarTable("sky_application_service")]
    public partial class sky_application_service
    {
        public sky_application_service()
        {


        }
        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:False
        /// </summary>  
        /// 
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true, ColumnDescription = "主键")]//设置主键，设置自增，字段注释
        public int id { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>        
        /// 
        [SugarColumn(ColumnDescription = "服务名称")]
        public string service_name { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>   
        /// 
        [SugarColumn(ColumnDescription = "服务描述", IsNullable  = true)]
        public string service_describe { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>    
        /// 
        [SugarColumn(ColumnDescription = "服务创建时间")]
        public string create_time { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>    
        /// 
        [SugarColumn(ColumnDescription = "服务更新时间")]
        public string update_time { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>    
        ///  
        /// 
        [SugarColumn(ColumnDescription = "可容纳用户总数 默认初始化为30用户数")]
        public int? use_total { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>   
        /// 
        [SugarColumn(ColumnDescription = "已使用数", IsNullable = true)]
        public int? use_opened_num { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>    
        /// 
        [SugarColumn(ColumnDescription = "", IsNullable = true)]
        public int? use_surplus_num { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>      
        /// 
        [SugarColumn(ColumnDescription = "删除1 其他 0")]
        public int? is_delete { get; set; }

    }
}
