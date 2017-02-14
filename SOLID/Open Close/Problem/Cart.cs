using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Open_Close
{
    // calculate total and charge
    //THIS CHECKOUT METHOD IS VIOLATING OPEN CLOSE PRINCIPLE.
    //BECUASE IF I WANT TO ADD NEW PAYMENT METHOD THEN WE HAVE TO CHANGE THE CHECKOUT METHOD.
    //IT SHOULD BE CLOSE TO CHANGE AND OPEN TO EXTEND.

    public class Cart
    {
        public void Checkout()
        {
            //In my problem domain below are the variables.
            //Out of that 1st and 2nd are the volatile.
            //According to Open Close principle we shoud create one Interface/Abstarction against volatile variables.
            //In my example for no 1 i created Item .
            //In my example no 2 i created PaymentMethod.
            //1.suger,Rice...
            //2.Cash,Cradit,....
            //3.Cart
            //First  i will look for high level Model which is solid in my example it is Cart.

            var items = new List<Item> { new Item("Suger", 56), new Item("Rice", 23) };

            var total = 0;

            foreach (var item in items)
            {
                total += item.Price;
            }

            ChargeByCash(total);

        }

        private void ChargeByCash(int total)
        {
            //by cash.
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





