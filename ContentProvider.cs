using WatsonWebserver.Core;
using WatsonWebserver.Lite;

namespace QRCodeGenerator
{
    internal class ContentProvider
    {
        private string? MimeType { get; set; }
        private Func<byte[]>? FuncGetData;

        public ContentProvider(){}

        public void Start()
        {
            WebserverSettings settings = new WebserverSettings("192.168.1.2", 2321);
            WebserverLite listener = new WebserverLite(settings,OnGetContext);
            listener.Start();
        }

        private async Task OnGetContext(HttpContextBase  context)
        {
            if (FuncGetData == null || MimeType == null)
                await SendEmptyMessage(context.Response);
            else
                await SendMessage(context.Response,MimeType, FuncGetData.Invoke());
            return;
        }

        private static async Task SendMessage(HttpResponseBase response,string mime, byte[] data)
        {
            response.StatusCode = 200;
            response.ContentType = mime;
            await response.Send(data);
        }

        private static async Task SendEmptyMessage(HttpResponseBase response)
        {
            response.StatusCode = 200;
            await response.Send();
        }


        public void SetData(string mime, Func<byte[]> func)
        {
            MimeType = mime;
            FuncGetData = func;
        }
    }
}
