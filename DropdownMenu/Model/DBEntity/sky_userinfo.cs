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
    [SugarTable("sky_userinfo")]
    public partial class sky_userinfo
    {
        public sky_userinfo()
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
        [SugarColumn(ColumnDescription = "", IsNullable = true)]
        public string apply_souse { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        /// 
        [SugarColumn(ColumnDescription = "", IsNullable = true)]
        public string service_describe { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>         
        /// 
        [SugarColumn(ColumnDescription = "", IsNullable = true)]
        public string company { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string english_abbreviation { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>          
        /// 
        [SugarColumn(ColumnDescription = "", IsNullable = true)]
        public string position { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string name { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string phone { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>    
        /// 
        [SugarColumn(ColumnDescription = "", IsNullable = true)]
        public string email { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string open_date { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string close_date { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string account_number { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>      
        /// 
        [SugarColumn(ColumnDescription = "", IsNullable = true)]
        public string use_name { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>     
        /// 
        [SugarColumn(ColumnDescription = "", IsNullable = true)]
        public string start_password { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public int? status { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>  
        /// 
        [SugarColumn(ColumnDescription = "", IsNullable = true)]
        public string user_describe { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>         
        /// 
        [SugarColumn(ColumnDescription = "", IsNullable = true)]
        public int? user_sign { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string services_id { get; set; }

    }
}
