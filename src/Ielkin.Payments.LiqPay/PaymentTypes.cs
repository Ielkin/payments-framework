using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ielkin.Payments.LiqPay
{
    public class PaymentTypes
    {
        public static string Card { get { return "card"; } }
        public static string LiqPay { get { return "liqpay"; } }
        public static string PosTerminal { get { return "delayed"; } }
        public static string Privat24 { get { return "privat24"; } }
    }
}
