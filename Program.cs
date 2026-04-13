namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //VIP x = new VIP(1,4,"s");
            //x.print();
            //x.Book();

            Ticket t1 = new StandardTicket(3, 100, "Movie C");

            Ticket t2 = new VIP(2, 100, "Movie B");
            Ticket t3 = new IMAX(3, 100, "Movie C" );

            //Ticket t4=new VIP
            //Ticket t4 =new IMAX(3, 100),

            t1.Book();
            t2.Book();
            t3.Book();

            Cinema c=new Cinema();
            c.AddTicket(t1);
            c.AddTicket(t2);
            c.AddTicket(t3);

            c.PrintAllTickets();

        }
    }
}
