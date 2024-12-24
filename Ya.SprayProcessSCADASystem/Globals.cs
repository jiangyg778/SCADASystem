using IoTClient.Clients.PLC;
using IoTClient.Common.Enums;
using IoTClient.Enums;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ya.SprayProcessSCADASystem
{
    public static class Globals
    {
        public static IServiceProvider ServiceProvider;
        public static IniFile IniFile = new IniFile(Application.StartupPath + "\\config.ini");
        public static SiemensClient SiemensClient;

        public static string PlcVarConfigPath; // plc配置文件路径

        // cpu类型
        public static SiemensVersion CpuType;

        // ip地址
        public static string IpAddress;

        // 端口号
        public static int Port;

        // 插槽号
        public static byte Slot;

        // 机架号
        public static byte Rack;

        // plc链接超时时间
        public static int ConnectTimeOut;

        // plc读取间隔时间
        public static int ReadTimeInterval;

        // plc重连时间间隔
        public static int ReConnectTimeInterval;

        // plc变量地址字典
        public static Dictionary<string, DataTypeEnum> ReadDic = new Dictionary<string, DataTypeEnum>();

        // plc变量值 读取的字典
        public static Dictionary<string, object> DataDic = new Dictionary<string, object>();

        //plc变量值 写入的字典
        public static Dictionary<string, object> WriteDic = new Dictionary<string, object>();

        public static bool PlcWrite(string varName, dynamic value)
        {
            if (SiemensClient != null && SiemensClient.Connected)
            {
                string address = (string)WriteDic[varName];
                var res = SiemensClient.Write(address, value);

                if (res.IsSucceed)
                {
                    return true;
                }
                return false;
            }
            return false;
        }

    }
}
