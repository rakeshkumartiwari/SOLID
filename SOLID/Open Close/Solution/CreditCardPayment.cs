using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Open_Close.Solution
{

    class CreditCardMethodType : IProvidePaymentMethod
    {
        public void Charge(double total) { }
    }
}
