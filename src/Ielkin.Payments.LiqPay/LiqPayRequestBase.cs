using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Ielkin.Payments.LiqPay
{
    public class LiqPayRequestBase
    {
        [JsonProperty(PropertyName = "version")]
        public int Version { get; set; }
    }
}
