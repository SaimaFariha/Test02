using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_AccessModifierr
{
	public class SellBicycle
    {
        private int Price { get; set; }
        protected int Amount { get; set; }
        protected void SetPrice(int price)
        {
            price = price;
        }
        protected void Invoice()
        {
            Console.WriteLine($"Your total is{Price * Amount}");
        }
    }

}
