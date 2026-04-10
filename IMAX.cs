using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class IMAX : Ticket
    {
        public override Ticket clone()
        {

            return new IMAX
            {
                isBooked = this.isBooked,
                //movieName=
            };
        }

        //public override void Print()
        //{
        //    Console.WriteLine("IMAX Ticket");
        //    Console.WriteLine("Status: " + (isBooked ? "Booked" : "Not Booked"));
        //}

        public override void print()
        {
            throw new NotImplementedException();
        }
    }
}
