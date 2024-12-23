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

            //������������
            var services = new ServiceCollection();
            //ע�����
            ConfigureService(services);
            //���������ṩ��
            var serviceProvider = services.BuildServiceProvider();
            ApplicationConfiguration.Initialize();
            //��ȡ����
            var frmMain = serviceProvider.GetService<FrmMain>();
            Application.Run(frmMain);
        }

        private static void ConfigureService(ServiceCollection services)
        {
            //����������У�ȷ�е�˵��ָ�������еģ����з��Ϲ���Ľӿں����ǵ�ʵ����ע�뵽����ע�������С�
            services.AddDependencyInjection(new List<Assembly>() { typeof(Program).Assembly });
        }
    }
}