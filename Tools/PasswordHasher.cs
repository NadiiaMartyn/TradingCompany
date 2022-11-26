using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public class PasswordHasher
    {
        private const int c_SaltSize = 16;
        private const int c_KeySize = 32;
        private const int c_NumberOfIterations = 1000;
        public static string Hash(string password)
        {
            using (var algorithm = new Rfc2898DeriveBytes(password, c_SaltSize, c_NumberOfIterations, HashAlgorithmName.SHA256))
            {
                var key = Convert.ToBase64String(algorithm.GetBytes(c_KeySize));
                var salt = Convert.ToBase64String(algorithm.Salt);
                return $"{c_NumberOfIterations}.{salt}.{key}";
            }
        }

        public static bool Check(string hash, string password)
        {
            string[] parts = hash.Split('.', 3);
            if (parts.Length != 3) 
                throw new FormatException("Unexpected hash format. " + "Should be formatted as `{iterations}.{salt}.{hash}`");
            int iterations = Convert.ToInt32(parts[0]);
            byte[] salt = Convert.FromBase64String(parts[1]); 
            byte[] key = Convert.FromBase64String(parts[2]);
            using (var algorithm = new Rfc2898DeriveBytes(password, salt, iterations, HashAlgorithmName.SHA256))
                return algorithm.GetBytes(c_KeySize).SequenceEqual(key);
        }
    }
}
