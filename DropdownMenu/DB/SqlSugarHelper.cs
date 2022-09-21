using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using Newtonsoft.Json;
using System.IO;

namespace DropdownMenu.DB
{
    public class SqlSugarHelper
    {
        public void InintialDB()
        {
            string path = AppDomain.CurrentDomain.SetupInformation.ApplicationBase  + "userSqlite.db";
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
            ConnectionConfig connectionConfig = new ConnectionConfig();
            connectionConfig.DbType = DbType.Sqlite;
            connectionConfig.IsAutoCloseConnection = true;
            //  自动释放数据务，如果存在事务，在事务结束后释放
            connectionConfig.InitKeyType = InitKeyType.Attribute;
                connectionConfig.ConnectionString = $"Data Source={path};version=3.0";
            using (SqlSugarClient sugarClient = new SqlSugarClient(connectionConfig)) {
                sugarClient.DbFirst.CreateClassFile(@"D:\代码生成\后端\dotnet\dbModels\");
            } 
        }
    }
}
