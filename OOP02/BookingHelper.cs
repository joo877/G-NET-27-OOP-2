using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP02
{
    internal static class BookingHelper
    {
        private static int counter =0;
        public static double CalcGroupDiscount(int numberOfTickets, double pricePerTicket)
        {

            if(numberOfTickets >= 5)
                return numberOfTickets * pricePerTicket * 0.9; 
            return numberOfTickets * pricePerTicket;


        }


        public static string GenerateBookingReference()
        {
            counter++;
            return $"BK-{counter}  ";
          
        
        }
    }
}
