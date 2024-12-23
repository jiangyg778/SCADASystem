using HZY.Framework.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog;
using NLog.Extensions.Logging;
using System.Reflection;

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
            Application.Run(frmMain);
        }

        private static void ConfigureService(ServiceCollection services)
        {
            ///ע������ע�� ͨ�����򼯵�ĳһ���� �Զ�ע������ڵ��� ������ ����ʵ���� ISingletonDependency֮��� �ӿ�
            services.AddDependencyInjection(new List<Assembly>() { typeof(Program).Assembly });




            //ע��json����
            IConfigurationBuilder cfgBuilder = new ConfigurationBuilder()
                .SetBasePath(Environment.CurrentDirectory)
                .AddJsonFile("appsettings.json");

            //����json����
            IConfiguration configuration = cfgBuilder.Build();
            //ע��json��������
            services.AddSingleton<IConfiguration>(configuration)
                .AddLogging(loggerBuilder => {
                    loggerBuilder.ClearProviders();//���������־���ṩ��
                    loggerBuilder.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace);//���õȼ�
                    loggerBuilder.AddNLog();
                });

            //��ȡNLog������Ϣ
            var nlogConifg = configuration.GetSection("NLog");

            //����Nlog����
            LogManager.Configuration = new NLogLoggingConfiguration(nlogConifg);
        }
    }
}