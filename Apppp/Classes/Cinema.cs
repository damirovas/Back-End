using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Apppp.Classes.Seat;

namespace Apppp.Classes
{
    internal class Cinema
    {
        private static int _id { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Hall> Halls { get; set; } = new List<Hall>();
        public Cinema(string name)
        {
            Id = ++_id;
            Name = name;
        }
        public void DisplayHallSeats(int hallId)
        {
            Hall hall = null;
            foreach (Hall h in Halls)
            {
                if (h.Id == hallId)
                {
                    hall = h;
                    break;
                }
            }
            if (hall != null)
            {
                Console.Clear();
                for (int i = 0; i < hall.RowCount; i++)
                {
                    for (int j = 0; j < hall.ColCount; j++)
                    {
                        var seat = hall.Seats[i, j];
                        
                        if (SeatStatus.Available.Equals(seat.Status))
                        {
                            Console.BackgroundColor=ConsoleColor.Green;
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Red;

                        }
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Hall tapilmadi");
            }
        }

        public void AddHall(Hall hall)
        {
            Halls.Add(hall);
            Console.WriteLine($"{hall.Name} is added");
        }
    }
}
