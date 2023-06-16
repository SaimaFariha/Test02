using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_AccessModifierr
{
    internal class BasicAccessModifier
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Bicycle bicycle = new Bicycle();
            bicycle.Wheels = 3;
            bicycle.AttachedWheel();
            bicycle.StartBicycle();
            bicycle.GenerateInvoice();
        }
    }
}

