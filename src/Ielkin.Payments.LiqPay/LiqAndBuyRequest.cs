using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Ielkin.Payments.LiqPay
{
    public class LiqAndBuyRequest : LiqPayRequestBase
    {
        [JsonProperty(PropertyName = "public_key")]
        public string PublicKey { get; set; }

        [JsonProperty(PropertyName = "amount")]
        public float Amount { get; set; }

        [JsonProperty(PropertyName = "currency")]
        public string Currency { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "order_id")]
        public string OrderId { get; set; }

        [JsonProperty(PropertyName = "recurringbytoken")]
        public string ReccuringTransactionToken { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string TransactionType { get; set; }

        [JsonProperty(PropertyName = "subscribe")]
        public string IsSubscriptionPayment { get; set; }

        [JsonProperty(PropertyName = "subscribe_date_start")]
        public string SubscriptionStartDate { get; set; }

        [JsonProperty(PropertyName = "subscribe_periodicity")]
        public string SubscriptionDurationUnit { get; set; }

        [JsonProperty(PropertyName = "product_url")]
        public string ProductUrl { get; set; }

        [JsonProperty(PropertyName = "server_url")]
        public string IpnEndpointUrl { get; set; }

        [JsonProperty(PropertyName = "result_url")]
        public string RedirectUrl { get; set; }

        [JsonProperty(PropertyName = "pay_way")]
        public string PaymentType { get; set; }

        [JsonProperty(PropertyName = "language")]
        public string Language { get; set; }

        [JsonProperty(PropertyName = "sandbox")]
        public string SandboxEnabled { get; set; }
    }
}
