using NetCoreServer;
using System.Net;

namespace QRCodeGenerator
{
    internal sealed class ContentProvider:HttpServer
    {
        private struct Item
        {
            public string Mime;
            public Func<byte[]> _FuncGetData;
            public Item(string mime, Func <byte[]> func)
            {
                Mime = mime;
                _FuncGetData = func;
            }
        }
        private Dictionary<string, Item> _TokenItemDictionary = new Dictionary<string, Item>();
        private Dictionary<string, string> _TypeTokenDictionary = new Dictionary<string, string>();
        private class HttpSession1 : HttpSession
        {
            public HttpSession1(HttpServer server) : base(server){}
            protected override void OnReceivedRequest(HttpRequest request)
            {
                ContentProvider server = (ContentProvider)Server;
                string? token = TextUtil.GetQueryValue(request.Url, "token");
                if(token==null||!server._TokenItemDictionary.ContainsKey(token))
                    SendResponse(Response.MakeErrorResponse(403));
                else
                {
                    Item item = server._TokenItemDictionary[token];
                    SendResponse(Response.MakeGetResponse(item._FuncGetData.Invoke(), item.Mime));
                }
            }
        }

        public ContentProvider(string hostName, int port) : base(hostName, port) {}
        public ContentProvider(IPAddress address,int port) : base(address,port) {}
        public ContentProvider(DnsEndPoint dnsEndPoint) : base(dnsEndPoint) {}
        protected override TcpSession CreateSession() => new HttpSession1(this);
        public string SetData(string mime, Func<byte[]> func)
        {
            string token = func.GetHashCode().ToString("X");
            string majorType = mime.Substring(0, mime.IndexOf('/'));
            if (_TypeTokenDictionary.ContainsKey(majorType))
            {
                _TokenItemDictionary.Remove(_TypeTokenDictionary[majorType]);
                _TypeTokenDictionary.Remove(majorType);
            }
            _TypeTokenDictionary[majorType] = token;
            _TokenItemDictionary[token] = new Item(mime, func);
            return token;
        }
    }
}
