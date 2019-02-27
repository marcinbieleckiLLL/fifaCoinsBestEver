using System;
using System.Text;

namespace fifaCoinsBestEver.Services
{
    class PwdEncrypter : IPwdEncrypter
    {
        public PwdEncrypter()
        {
        }

        public string encrypt(string pwd)
        {
            var bytes = new UTF8Encoding().GetBytes(pwd);
            byte[] hashBytes;
            using (var algorithm = new System.Security.Cryptography.SHA512Managed())
            {
                hashBytes = algorithm.ComputeHash(bytes);
            }
            return Convert.ToBase64String(hashBytes);
        }
    }

    public interface IPwdEncrypter
    {
        String encrypt(String pwd);
    }
}