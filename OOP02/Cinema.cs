    using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP02
{
    internal class Cinema
    {
        private Ticket[] _teket = new Ticket[20];

        public Ticket? this[int index]
        {

            get
            {
                if (index >= 0 && index < _teket.Length)
                    return _teket[index];
                return null;
            }
            set
            {
                if (index >= 0 && index < _teket.Length)
                    _teket[index] = value;
            }

        }

        public Ticket this[string movie]
        {
            get
            {
                foreach (var ticket in _teket)
                {

                    if (ticket.MoveName == movie)
                        return ticket;
                }

                return null;

            }

        }



        public bool AddTicket(Ticket t)
        {

            for (int i = 0; i < _teket.Length; i++)
            {

                if (_teket[i] == null)
                {
                    _teket[i] = t;
                    return true;
                }

            }
            return false;

        }






    }
}
