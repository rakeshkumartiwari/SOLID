using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Open_Close.Solution
{
    public interface IProvidePaymentMethod
    {
        void Charge(double total);
    }
}
