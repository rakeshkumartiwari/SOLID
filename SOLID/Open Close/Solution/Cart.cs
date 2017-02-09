using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Open_Close.Solution
{
    public class Cart
    {
        public void Checkout(List<Item> items, IProvidePaymentMethod paymentMethod)
        {
            var total = 0;

            foreach (var item in items)
            {
                total += item.price;
            }

            paymentMethod.Charge(total);

        }

    }
}
