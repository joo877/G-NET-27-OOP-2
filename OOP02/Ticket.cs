
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02
{
    internal class Ticket
    {
        private string _movieName;
         private double _price;
        public Enum.Type Ticket_Type { get; set; }
        public Seat Seat_location { get; set; }

        public double PriceAfterTax => _price+_price*.14;

        public static int ticketCounter = 0;

        public  int TicketId  { get; set; }
        public string MoveName 
        { 
        
        get
            {
                return _movieName;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    Console.WriteLine(" MoveName :cannot be null or empty");
                _movieName=value;
            }
        }

        public double Price
        {
            get { return _price; }
            set {
            
            if(value > 0)
                    _price = value;
                else
                    Console.WriteLine("Price must be greater than zero");


            }
        }



        
        public Ticket(string name , Enum.Type type , Seat seat, double price)
        {
            _movieName=name;
            Ticket_Type=type;
            Seat_location=seat;
            Price=price;
            ticketCounter++;
            TicketId = ticketCounter;


        }


        public static int GetTotalTicketsSold()
        {
            return ticketCounter;
        }



    }
}
