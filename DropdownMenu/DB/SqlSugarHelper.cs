using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using Newtonsoft.Json;
using System.IO;
using System.Reflection;
using System.Linq;
using DropdownMenu.Model.DBEntity;

namespace DropdownMenu.DB
{
    public class SqlSugarHelper
    {
        ConnectionConfig connectionConfig = null;
        public void InintialDB()
        {
            Console.WriteLine("================SQLITE数据库初始化加载==================");
            string path = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "userSqlite.db";
            Console.WriteLine("================SQLITE数据库文件userSqlite.db加载成功==================");
            if (!File.Exists(path))
            {
                Console.WriteLine("================SQLITE数据库文件userSqlite.db开始创建==================");
                File.Create(path).Close();
                Console.WriteLine("================SQLITE数据库文件userSqlite.db创建完成==================");
                Console.WriteLine($"文件路径：{path}");
            }
            Console.WriteLine($"文件路径：{path}");
            connectionConfig = new ConnectionConfig();
            connectionConfig.DbType = DbType.Sqlite;
            connectionConfig.IsAutoCloseConnection = true;
            //  自动释放数据务，如果存在事务，在事务结束后释放
            connectionConfig.InitKeyType = InitKeyType.Attribute;
            Console.WriteLine("SQLITE数据源获取");
            connectionConfig.ConnectionString = $"Data Source={path}";

            
            using (SqlSugarClient sugarClient = new SqlSugarClient(connectionConfig))
            {
                Console.WriteLine("命名空间过滤开始");
                //  sugarClient.DbFirst.CreateClassFile(@"D:\代码生成\后端\dotnet\dbModels\");
                Type[] types = Assembly.LoadFrom("DropdownMenu.dll")//如果 .dll报错，可以换成 xxx.exe 有些生成的是exe 

                    .GetTypes().Where(t => t.FullName.Contains("Model.DBEntity"))//命名空间过滤，当然你也可以写其他条件过滤 引用System.Linq;
                   .ToArray();//断点调试一下是不是需要的Type，不是需要的在进行过滤             
                              //同步数据表结构
                Console.WriteLine("同步数据表结构");
                sugarClient.DbMaintenance.CreateDatabase();
                Console.WriteLine("多表同步");
                sugarClient.CodeFirst.SetStringDefaultLength(1024).InitTables(types);//多表同步  

                
            }

            Console.WriteLine("数据库生成成功");

            Console.WriteLine("想要停止请关闭进程,然后\n要在调试停止时自动关闭控制台，\n请启用“工具”->“选项”->“调试”->“调试停止时自动关闭控制台”。\n按任意键关闭此窗口. .");
        }

        public int ExecuteInsert(sky_application_service application_Service)
        {
            int h = 0;
            using (SqlSugarClient sugarClient = new SqlSugarClient(connectionConfig))
            {
                h = sugarClient.Insertable<sky_application_service>(application_Service).ExecuteCommand();
            }
            return h;
        }
        public sky_application_service Queryable(sky_application_service application_Service)
        {
            sky_application_service sky = null;
            using (SqlSugarClient sugarClient = new SqlSugarClient(connectionConfig))
            {
                sky = sugarClient.Queryable<sky_application_service>().Where(m => m.service_name.Contains(application_Service.service_name)).First();
            }
            return sky;
        }
        public sky_application_service UpdateQuery(sky_application_service application_Service)
        {
            sky_application_service sky = null;
            using (SqlSugarClient sugarClient = new SqlSugarClient(connectionConfig))
            {
                sugarClient.Updateable<sky_application_service>(application_Service).WhereColumns(it => new { it.id }).ExecuteCommand();
                sky = sugarClient.Queryable<sky_application_service>().First();
            }
            return sky;
        }
        public sky_application_service Delete(int Id)
        {
            sky_application_service sky = null;
            using (SqlSugarClient sugarClient = new SqlSugarClient(connectionConfig))
            {
                sugarClient.Deleteable<sky_application_service>().In(it => it.id, Id).ExecuteCommand();
                sky = sugarClient.Queryable<sky_application_service>().First();
            }
            return sky;
        }
    }
}
