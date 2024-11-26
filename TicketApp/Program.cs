using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using TicketApp.Classes;

namespace TicketApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = EnterChoosens();
            Cinema cinema = new Cinema("ParkCinema");
            while (result != 0)
            {
                switch (result)
                {
                    case 1:
                        AddHall(cinema);
                        EnterChoosens();
                        break;
                    case 2:
                        
                        
                        result = EnterChoosens();
                    break;
                        case 3:
                        cinema.ShowHall(cinema);
                        result= EnterChoosens();
                        break;
                    default:
                        Console.WriteLine("Something went wrong");
                        result = EnterChoosens();
                        break;

                
            }
        }
        static int EnterChoosens()
        {
            Console.WriteLine("cixis etmek ucun o secin");
            Console.WriteLine("Hall elave etmek ucun 1 secin");
            Console.WriteLine("Elave olunmus hall gormek ucun2 secin");
            Console.WriteLine("Hallun yerlerini gostermek ucun 3 secim edin");
            Console.WriteLine("Yer rezerv etmek ucun 4 secim edin");
            int result = int.Parse(Console.ReadLine());
            return result;
        }
        static void AddHall(Cinema cinema)
        {
            
            Console.Write("Hall adı: ");
            string hallName = Console.ReadLine();
            Console.Write("Sıra sayı: ");
            int rowCount = int.Parse(Console.ReadLine());
            Console.Write("Sütun sayı: ");
            int colCount = int.Parse(Console.ReadLine());
            Hall newHall = new Hall(hallName, rowCount, colCount);
            cinema.AddHall(newHall);
            Console.WriteLine("Yeni Hall əlavə olundu.");   
        }

        

    }
}
