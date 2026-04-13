using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    partial class Cinema 
    {
         List <Iprintable> Tickets = new List<Iprintable>();
        public void PrintAllTickets()
        {
            foreach (var tickets in Tickets)
            {
                tickets.print();

            }
        }

     

    public void ShowStatistics()
    {
        Console.WriteLine($"Total Tickets: {Tickets.Count}");
    }
    }
}
