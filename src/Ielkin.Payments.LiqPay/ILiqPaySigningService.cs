using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ielkin.Payments.LiqPay
{
    public interface ILiqPaySigningService
    {
        string Sign(string requestData);
    }
}
