using System.Security.Cryptography;
using System.Text;

namespace CSharpBlockchain.Scripts.Crypto {
    public static class Hashing {
        public static byte[] GetHash(string inputString)
        {
            HashAlgorithm algorithm = SHA256.Create();
            return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }
        
        public static string FromString(string str) {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(str)) {
                sb.Append(b.ToString("X2"));
            }
            return sb.ToString();
        }
    }    
}