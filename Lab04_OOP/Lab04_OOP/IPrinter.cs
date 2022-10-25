using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_OOP
{
    class Printer
    {
        public static void IAmPrinting(Object obj)
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine(obj.GetType());
            Console.WriteLine(obj.ToString());
        }
    }
}

