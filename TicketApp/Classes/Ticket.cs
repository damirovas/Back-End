using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketApp.Classes
{
    internal class Ticket
    {
        private static int _id;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int HallId { get; set; }
        public int SeatRow { get; set; }
        public int SeatColumn { get; set; }

        public Ticket(string firstname, string lastname, int hallId, int seatRow, int seatColumn)
        {
            Id = ++_id;
            FirstName = firstname;
            LastName = lastname;
            HallId = hallId;
            SeatRow = seatRow;
            SeatColumn = seatColumn;
        }
    }
}
