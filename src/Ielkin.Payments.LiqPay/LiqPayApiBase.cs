using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Ielkin.Payments.LiqPay
{
    public class LiqPayApiBase
    {
        private ILiqPaySigningService _signingService;

        public LiqPayApiBase(ILiqPaySigningService signingService)
        {
            _signingService = signingService;
        }

        protected LiqPayData CreateRequestData<T>(T request)
        {
            string requestJson = JsonConvert.SerializeObject(request);

            string requestData = Convert.ToBase64String(Encoding.UTF8.GetBytes(requestJson));
            string signature = _signingService.Sign(requestData);

            return new LiqPayData()
            {
                Data = requestData,
                Signature = signature,
            };
        }

        protected T ExtractResopnse<T>(LiqPayData responseData)
        {
            string responseJson = Encoding.UTF8.GetString(Convert.FromBase64String(responseData.Data));

            string signature = _signingService.Sign(responseJson);

            if (!signature.Equals(responseData.Signature))
            {
                new InvalidOperationException(Resources.ErrorStrings.InvalidSignature);
            }

            object response = JsonConvert.DeserializeObject(responseData.Data);

            return (T)response;
        }
    }
}
