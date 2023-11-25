namespace QRCodeGenerator
{
    internal static class TextUtil
    {
        public static string? GetQueryValue(string url,string name)
        {
            if (!url.Contains("?")) return null;
            string query = url.Substring(url.LastIndexOf("?") + 1);
            foreach(string item in query.Split("&"))
            {
                string pair = item.Replace(" ", "");
                if (pair.StartsWith(name + "="))
                    return pair.Substring(pair.IndexOf('=') + 1);
            }
            return null;
        }
    }
}
