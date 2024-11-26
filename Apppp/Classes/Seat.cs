using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Apppp.Classes
{
    internal class Seat
    {
        public int RowSeat { get; set; }
        public int ColumnSeat { get; set; }
        public SeatStatus Status { get; set; }

        public Seat(int rowSeat, int colSeat)
        {
            RowSeat = rowSeat;
            ColumnSeat = colSeat;

        }
        public enum SeatStatus
        {
            Available,
            Reserved
        }

    }
}
