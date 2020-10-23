using System.Security.Cryptography;
using System.Text;

namespace PointOfSale.Lib.Encryptions
{
    public class EncryptTo
    {
        public static string MD5Hash(string value)
        {
            MD5CryptoServiceProvider MD5Code = new MD5CryptoServiceProvider();
            byte[] diziByte = Encoding.UTF8.GetBytes(value);
            diziByte = MD5Code.ComputeHash(diziByte);
            StringBuilder sb = new StringBuilder();
            foreach (byte ba in diziByte)
            {
                sb.Append(ba.ToString("x2").ToUpper());
            }
            return sb.ToString();
        }
    }
}