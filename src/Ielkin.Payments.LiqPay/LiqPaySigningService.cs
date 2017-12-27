using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json;

namespace Ielkin.Payments.LiqPay
{
    public class LiqPaySigningService : ILiqPaySigningService
    {
        private string _privateKey;

        public LiqPaySigningService(string privateKey)
        {
            _privateKey = privateKey;
        }

        public string Sign(string requestData)
        {
            SHA1 sha1 = new SHA1CryptoServiceProvider();

            byte[] signatureHash = sha1.ComputeHash(Encoding.UTF8.GetBytes(_privateKey + requestData + _privateKey));

            return Convert.ToBase64String(signatureHash);
        }
    }
}
