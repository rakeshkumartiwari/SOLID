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
            var items = new List<Item> { new Item("meal1", 56), new Item("meal2", 23) };

            var total = 0;

            foreach (var item in items)
            {
                total += item.price;
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
        string name; public int price;
        public Item(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
    }


//====================================================================================
    //SOLUTION:
    //IN ORDER TO FIX THIS PAYMENT METHOD INTERFACE HAS TO BE CREATED





  
}
