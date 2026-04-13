using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    static public class TicketExtensions
    {
        public static string GetTicket(this Ticket ticket) {
            return $"{ticket.BasePrice}";
        
        }





        //public static string GetReceipt(this Ticket ticket)
        //{
        //    return $"Movie: {ticket.MovieName}, Price: {ticket.BasePrice}";
        //}







    }
}
