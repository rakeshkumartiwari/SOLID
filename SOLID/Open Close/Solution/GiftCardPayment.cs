using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Open_Close.Solution
{

    public class GiftCardMethodType : IProvidePaymentMethod
    {
        public void Charge(double total) { }
    }
}
