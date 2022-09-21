using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropdownMenu.Model
{
    /// <summary>
    /// 应用服务器
    /// </summary>
    public class SkyApplicationService
    {
        /// <summary>
        /// id
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 服务名称
        /// </summary>
        public string service_name { get; set; }
        /// <summary>
        /// 服务描述
        /// </summary>
        public string service_describe { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime create_time { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime update_time { get; set; }
        /// <summary>
        /// 可容纳用户总数 默认初始化为30用户数
        /// </summary>
        public int use_total { get; set; }
        /// <summary>
        /// 已使用数
        /// </summary>
        public int use_opened_num { get; set; }
        /// <summary>
        /// 剩余数
        /// </summary>
        public int use_surplus_num { get; set; }
        /// <summary>
        /// 删除标识 0显示 1删除
        /// </summary>
        public int is_delete { get; set; }

    }
}
