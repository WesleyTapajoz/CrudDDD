using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace CrudMvc.Infra.CrossCutting.Criptografia
{
    public class CriptografiaSHA256
    {
        public static string GeraHashSHA256(string value)
        {
            using (SHA256 hash = SHA256.Create())
            {
                return value = String.Concat(hash
                              .ComputeHash(Encoding.UTF8.GetBytes(value))
                              .Select(item => item.ToString("x2")));
            }
        }
    }
}
