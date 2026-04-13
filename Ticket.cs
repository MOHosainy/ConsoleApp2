using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class Ticket : Iprintable
    {
        protected bool isBooked=false;

        public int Id { get; set; }
        public int BasePrice { get; set; }
        public string MovieName { get; set; }

        public Ticket(int id,int basePrice, string movieName)
        {
            Id= id;
            BasePrice= basePrice;
            MovieName= movieName;
        }

        public abstract double calculate();



        public abstract Ticket clone(); 


        public void Book()
        {
            if(isBooked)
            {
                Console.WriteLine("Already booked");
                return;
            }

            isBooked=true;

            
        }
        public void canacel()
        {
            if(!isBooked)
            {
                Console.WriteLine("Not booked yet");
                return;
            }
            isBooked = true;

        }


        public abstract void print();

        //void print();
    }
}
//}
