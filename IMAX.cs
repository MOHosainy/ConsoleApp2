using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class IMAX : Ticket
    {
        public IMAX(int id, int basePrice, string movieName) : base(id, basePrice, movieName)
        {
        }

        public override double calculate()
        {
            throw new NotImplementedException();
        }

        public override Ticket clone()
        {

            return new IMAX(2,4,"fd")
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
