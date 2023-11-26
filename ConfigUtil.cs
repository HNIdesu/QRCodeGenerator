using HNIdesu.Configuration;
using System.Net;
using System.Net.Sockets;

namespace QRCodeGenerator
{
    internal static class ConfigUtil
    {
        private static ConfigManager _ConfigManager = ConfigManager.CreateOrOpenConfig("config");
        private static string CurrentHostName = Dns.GetHostAddresses(Dns.GetHostName()).First((ip) => ip.AddressFamily == AddressFamily.InterNetwork).ToString();
        public static string Host
        {
            get => _ConfigManager.GetString("host", CurrentHostName);
            set
            {
                var editor= _ConfigManager.Edit();
                editor.Put("host", value);
                editor.Commit();
                _ConfigManager.Update();
            }
        }

        public static int Port
        {
            get => _ConfigManager.GetInt32("port",2321);
            set
            {
                var editor = _ConfigManager.Edit();
                editor.Put("port", value);
                editor.Commit();
                _ConfigManager.Update();
            }
        }

        public static string? NetTraverseUrl
        {
            get => _ConfigManager.GetString("net_traverse_url");
            set
            {
                if (value != null)
                {
                    var editor = _ConfigManager.Edit();
                    editor.Put("net_traverse_url", value);
                    editor.Commit();
                    _ConfigManager.Update();
                }
                    
            }
        }


        public static bool EnableNetTraverse
        {
            get => _ConfigManager.GetInt32("enable_net_traverse",0)==1;
            set
            {
                var editor = _ConfigManager.Edit();
                editor.Put("enable_net_traverse", value?1:0);
                editor.Commit();
                _ConfigManager.Update();
            }
        }




    }

}
