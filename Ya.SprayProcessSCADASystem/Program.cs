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
            Globals.ServiceProvider = serviceProvider;
            ApplicationConfiguration.Initialize();
            //获取服务
            var frmMain = serviceProvider.GetService<FrmMain>();
            Application.Run(frmMain);
        }

        private static void ConfigureService(ServiceCollection services)
        {
            ///注册依赖注入 通过程序集的某一个类 自动注册程序集内的类 条件是 该类实现了 ISingletonDependency之类的 接口
            services.AddDependencyInjection(new List<Assembly>() { typeof(Program).Assembly });
        }
    }
}