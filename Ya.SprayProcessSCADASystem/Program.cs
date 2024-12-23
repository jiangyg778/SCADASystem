using HZY.Framework.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
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

            //创建服务容器
            var services = new ServiceCollection();
            //注册服务
            ConfigureService(services);
            //构建服务提供者
            var serviceProvider = services.BuildServiceProvider();
            ApplicationConfiguration.Initialize();
            //获取服务
            var frmMain = serviceProvider.GetService<FrmMain>();
            Application.Run(frmMain);
        }

        private static void ConfigureService(ServiceCollection services)
        {
            //将解决方案中（确切地说是指定程序集中的）所有符合规则的接口和它们的实现类注入到依赖注入容器中。
            services.AddDependencyInjection(new List<Assembly>() { typeof(Program).Assembly });
        }
    }
}