using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class BookingHelper
    {
        public static void printall(Iprintable[] items)
        {
            foreach (var item in items)
            {
                item.print();
            }
        }
    }
}
