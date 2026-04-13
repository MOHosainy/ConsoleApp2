using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class VIP : Ticket
    {
        public override Ticket clone()
        {
            return new VIP(1,2,"s")
            {
                 isBooked =  this.isBooked,

            };
        }

      public VIP(int id,int basePrice,string movieName) :base(id,basePrice,movieName) 
        {

        }

        public override void print()
        {
            Console.WriteLine("Status: " + (isBooked ? "Booked" : "Not Booked"));
        }

        public override double calculate()
        {
            throw new NotImplementedException();
        }
    }
}
