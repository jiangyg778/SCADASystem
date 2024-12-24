using Microsoft.Extensions.DependencyInjection;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ya.DAL
{
    public static class DB
    {
        public static ISqlSugarClient SqlSugarClient { get; set; }
        public static void AddSqlSugarSetup(this IServiceCollection services, SqlSugar.DbType dataType, string conn)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddSingleton<ISqlSugarClient>(s =>
            {
                SqlSugarClient = new SqlSugarScope(new ConnectionConfig()
                {
                    DbType = dataType, // 数据库类型 比如：SqlServer、MySql、Oracle
                    ConnectionString = conn,// 数据库连接字符串 比如:server=.; uid=sa; pwd=123456; database=MyDb 
                    IsAutoCloseConnection = true // 开启自动释放模式和EF原理一样我就不多解释了
                });
                return SqlSugarClient;
            });
        }
    }
}
