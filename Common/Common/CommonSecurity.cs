using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class CommonSecurity
    {
        public static HashAlgorithm GetDefaultUserPasswordHash()
        {
            return SHA256.Create();
        }
        public static byte[] GetHash(HashAlgorithm HashAlgorithm, string Input)
        {
            return HashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(Input));
        }
    }
}
