using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Ielkin.Payments.LiqPay
{
    public class AcquiringApi : LiqPayApiBase, ILiqPayAcquiringApi
    {
        public AcquiringApi(ILiqPaySigningService signingService)
            : base(signingService)
        {
        }

        public CallbackResponse Callback(LiqPayData response)
        {
            CallbackResponse callbackResponse = ExtractResopnse<CallbackResponse>(response);

            return callbackResponse;
        }

        public string CreateLiqAndBuyUrl(LiqAndBuyRequest request)
        {
            string liqAndBuyUrl = "https://www.liqpay.com/api/checkout";

            var requestData = CreateRequestData(request);

            liqAndBuyUrl = liqAndBuyUrl + "?data=" + requestData.Data;
            liqAndBuyUrl = liqAndBuyUrl + "&signature=" + requestData.Signature;

            var formData = new Dictionary<string, string>();

            return null;
        }
    }
}
