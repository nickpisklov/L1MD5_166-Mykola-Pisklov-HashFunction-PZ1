using System.Text;
using System.Security.Cryptography;

namespace HashFunction
{
    public static class MySHA256
    {
        public static string GetHashCodeForMessage(string message)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(message));
                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    stringBuilder.Append(bytes[i].ToString("x2"));
                }
                return stringBuilder.ToString();
            }
        }
    }
}
