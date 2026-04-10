using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class VIP : Ticket
    {
        public override Ticket clone()
        {
            return new VIP
            {
                isBooked = this.isBooked,

            };
        }

        //public override void Print()
        //{
        //    Console.WriteLine("VIP Ticket");
        //    Console.WriteLine("Status: " + (isBooked ? "Booked" : "Not Booked"));
        //}

        public override void print()
        {
            Console.WriteLine("Status: " + (isBooked ? "Booked" : "Not Booked"));
        }
    }
}
