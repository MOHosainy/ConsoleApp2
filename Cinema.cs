using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Cinema 
    {
         List <Iprintable> Tickets = new List<Iprintable>();
        public void PrintAllTickets()
        {
            foreach (var tickets in Tickets)
            {
                tickets.print();

            }
        }
    }
}
