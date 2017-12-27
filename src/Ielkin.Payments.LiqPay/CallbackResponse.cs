using Newtonsoft.Json;

namespace Ielkin.Payments.LiqPay
{
    public class CallbackResponse
    {
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

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

        [JsonProperty(PropertyName = "type")]
        public string TransactionType { get; set; }

        [JsonProperty(PropertyName = "transaction_id")]
        public string TransactionId { get; set; }

        [JsonProperty(PropertyName = "sender_phone")]
        public string PhoneNumber { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "card_token")]
        public string PaymentToken { get; set; }
    }
}