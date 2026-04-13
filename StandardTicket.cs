using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class StandardTicket :  Ticket
    {
        //public override void Print()
        //{
        //    Console.WriteLine("Standard Ticket");
        //    Console.WriteLine("Status: " + (isBooked ? "Booked" : "Not Booked"));
        //}


        public StandardTicket(int id, int basePrice, string movieName):base(id, basePrice, movieName) 
        {
            
        }
        public override double calculate() { return BasePrice; }

        public override Ticket clone()
        {
            throw new NotImplementedException();
        }

        public override void print()
        {
            throw new NotImplementedException();
        }
    }
}
