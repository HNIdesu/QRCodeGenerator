using System.Net;

namespace QRCodeGenerator
{
    internal class ContentProvider
    {
        private string? MimeType { get; set; }
        private Func<byte[]>? FuncGetData;

        public ContentProvider(){}

        public void Start()
        {
            HttpListener listener = new HttpListener();
            listener.Prefixes.Add("http://192.168.1.2:2321/");
            listener.Start();
            listener.BeginGetContext(OnGetContext, listener);
        }

        private void OnGetContext(IAsyncResult asyncResult)
        {
            HttpListener? listener = asyncResult.AsyncState as HttpListener;
            if (listener == null) return;
            var context = listener.EndGetContext(asyncResult);
            if (MimeType == null || FuncGetData == null)
                SendEmptyResponse(context);
            else
                SendResponse(context, MimeType, FuncGetData.Invoke());
            listener.BeginGetContext(OnGetContext, listener);
        }

        private void SendEmptyResponse(HttpListenerContext ctx)
        {
            ctx.Response.StatusCode = 404;
            ctx.Response.Close();
        }

        private void SendResponse(HttpListenerContext ctx,string mimeType, byte[] data)
        {
            var response = ctx.Response;
            response.StatusCode = 200;
            response.ContentType = mimeType;
            response.ContentLength64 = data.LongLength;
            response.OutputStream.Write(data);
            response.Close();
        }

        public void SetData(string mime, Func<byte[]> func)
        {
            MimeType = mime;
            FuncGetData = func;
        }
    }
}
