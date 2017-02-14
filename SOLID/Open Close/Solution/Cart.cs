using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Open_Close.Solution
{
    public class Cart
    {
        //High level design should depend on Abstraction not Detail.
        //High level design = Cart.
        //Abstravtion = Item,IProvidePaymentMethod
        //Detail = for List<Item>  Abstraction details are suger,Rice,Veg
        //Detail = for IProvidePaymentMethod Abstraction Details are credit,debit,cash
        public void Checkout(List<Item> items, IProvidePaymentMethod paymentMethod)
        {
            var total = 0;

            foreach (var item in items)
            {
                total += item.Price;
            }

            paymentMethod.Charge(total);

        }

    }
    public class Item
    {
        public int Price { get; set; }
        public string Name { get; set; }
        public Item(string name, int price)
        {
            Price = price;
            Name = name;
        }
    }
}
