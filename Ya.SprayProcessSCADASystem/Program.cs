using HZY.Framework.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog;
using NLog.Extensions.Logging;
using SqlSugar;
using System.Data;
using System.Reflection;
using Ya.DAL;
using Ya.Model;
using DbType = SqlSugar.DbType;

namespace Ya.SprayProcessSCADASystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //������������
            var services = new ServiceCollection();
            //ע�����
            ConfigureService(services);
            //���������ṩ��
            var serviceProvider = services.BuildServiceProvider();
            Globals.ServiceProvider = serviceProvider;
            ApplicationConfiguration.Initialize();
            //��ȡ����
            var frmMain = serviceProvider.GetService<FrmMain>();

            var db = Globals.ServiceProvider.GetService<ISqlSugarClient>();//��ȡsqlSugar����
            db.CodeFirst.SetStringDefaultLength(200)//����Ĭ�ϳ��� 200 
                .InitTables(typeof(AuthEntity), typeof(DataEntity), typeof(RecipeEntity), typeof(UserEntity));// ��ʼ����ṹ

            Application.Run(frmMain);
        }

        private static void ConfigureService(ServiceCollection services)
        {
            ///1. ע������ע�� ͨ�����򼯵�ĳһ���� �Զ�ע������ڵ��� ������ ����ʵ���� ISingletonDependency֮��� �ӿ�
            services.AddDependencyInjection(new List<Assembly>() { typeof(Program).Assembly });

            //ע��json����
            IConfigurationBuilder cfgBuilder = new ConfigurationBuilder()
                .SetBasePath(Environment.CurrentDirectory)
                .AddJsonFile("appsettings.json");

            //����json����
            IConfiguration configuration = cfgBuilder.Build();


            //2. ע��json��������
            services.AddSingleton<IConfiguration>(configuration)
                .AddLogging(loggerBuilder =>
                {
                    loggerBuilder.ClearProviders();//���������־���ṩ��
                    loggerBuilder.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace);//���õȼ�
                    loggerBuilder.AddNLog();
                });

            DbType dbType = Enum.Parse<DbType>(configuration["DbContexts:DbType"]);
            string connectionString = configuration[$"DbContexts:{dbType}:ConnectionString"];
            //3. ע��sqlSugar
            services.AddSqlSugarSetup(dbType, connectionString);


            //��ȡNLog������Ϣ
            var nlogConifg = configuration.GetSection("NLog");

            //����Nlog����
            LogManager.Configuration = new NLogLoggingConfiguration(nlogConifg);
        }
    }
}