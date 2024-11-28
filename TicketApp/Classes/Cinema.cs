using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TicketApp.Classes.Seat;

namespace TicketApp.Classes
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
                            Console.BackgroundColor = ConsoleColor.Green;
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

        
        public void AddHall(Hall hall )
        {
            Halls.Add( hall );
        }
        public void GetHall()
        {
            foreach (Hall h in Halls)
            {
                Console.WriteLine(h.ToString());
            }
        }
        public void ShowHall(Hall hall)
        {
            Console.Write("Hall ID seçin: ");
            int hallId = int.Parse(Console.ReadLine());

            var result = Halls.Find(h => h.Id == hallId);
            if (hall != null)
            {

                Console.WriteLine($"Hall Adı: {hall.Name}");
                Console.WriteLine($"Hall Ölçüləri: {hall.RowCount} sıra x {hall.ColCount} sütun");
                Console.WriteLine("Hall görünüşü:");

                for (int i = 0; i < hall.RowCount; i++)
                {
                    for (int j = 0; j < hall.ColCount; j++)
                    {
                        var seat = hall.Seats[i, j];
                        if (seat.Status == Seat.SeatStatus.Available)
                        {
                            Console.BackgroundColor = ConsoleColor.Green;
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                        }
                        Console.Write(" * ");

                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Bu ID-yə aid hall tapılmadı.");
            }
        }
        
    }
}
