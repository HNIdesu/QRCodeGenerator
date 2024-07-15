using HNIdesu.Configuration;
using System.Net;
using System.Net.Sockets;

namespace QRCodeGenerator
{
    internal sealed class AppConfig
    {
        private static readonly ConfigManager mConfigManager = ConfigManager.CreateOrOpen("config");
        private static readonly string mCurrentHostName = Dns.GetHostAddresses(Dns.GetHostName()).First((ip) => ip.AddressFamily == AddressFamily.InterNetwork).ToString();
        public static string Host
        {
            get => mConfigManager.Get("host", mCurrentHostName);
            set
            {
                var editor= mConfigManager.Edit();
                editor.Put("host", value);
                editor.Commit();
            }
        }

        public static int Port
        {
            get => mConfigManager.Get("port",2321);
            set
            {
                var editor = mConfigManager.Edit();
                editor.Put("port", value);
                editor.Commit();
            }
        }

        public static string? NetTraverseUrl
        {
            get => mConfigManager.Get("net_traverse_url",string.Empty);
            set
            {
                if (value != null)
                {
                    var editor = mConfigManager.Edit();
                    editor.Put("net_traverse_url", value);
                    editor.Commit();
                }
                    
            }
        }


        public static bool EnableNetTraverse
        {
            get => mConfigManager.Get("enable_net_traverse",0)==1;
            set
            {
                var editor = mConfigManager.Edit();
                editor.Put("enable_net_traverse", value?1:0);
                editor.Commit();
            }
        }




    }

}
