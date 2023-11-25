using PCLWebUtility;
using System.Security.Cryptography;
using System.Text;

namespace QRCodeGenerator
{
    internal static class EncryptUtil
    {
        internal static string EncryptText(string raw_data)
        {
            string encryped_data = WebUtility.UrlEncode(raw_data).Replace("%", "*");
            ToBase64Transform transform = new ToBase64Transform();
            byte[] buffer = Encoding.ASCII.GetBytes(encryped_data);
            encryped_data = Encoding.ASCII.GetString(transform.TransformFinalBlock(buffer, 0, buffer.Length));
            return encryped_data;
        }
    }
}
