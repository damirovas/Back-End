using Apppp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Apppp.Classes.Seat;

namespace Apppp
{
    internal class Hall
    {
        private static int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        public int RowCount { get; set; }
        public int ColCount { get; set; }
        public Seat[,] Seats { get; set; }

        public Hall(string name,int rowCount, int colCount)
        {
            Name = name;
            RowCount = rowCount;
            ColCount = colCount;
            Seats = new Seat[rowCount, colCount];
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    Seats[i, j] = new Seat(i,j);
                }
            }
        }
    }
}
