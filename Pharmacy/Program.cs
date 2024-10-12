namespace Pharmacy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Medicine[] medicines = new Medicine[10];
            int result = EnterChoosens();
            while(result != 0)
            {
                switch(result)
                {
                    case 1:
                        (int id, string name, string producer, decimal price) meddetails = EnterMedDetails();
                        Medicine medicine = new Medicine(meddetails.id, meddetails.name, meddetails.producer, meddetails.price);
                        for(int i = 0;i<medicines.Length;i++) 
                        {
                            if (medicines[i] != null) continue;
                            else
                            {
                                medicines[i] = medicine;
                                break;
                            }
                            
                        }
                        result = EnterChoosens();
                    break;
                        case 2:
                        foreach(Medicine med in medicines)
                        {
                            if (med is null) continue;
                            else
                            {
                                Console.WriteLine(med.GetFullMed());
                            }
                        }
                        result = EnterChoosens();
                        break;
                        default:
                        Console.WriteLine("Yanlis secim");
                        result = EnterChoosens(); 
                        break;
                }
            }

        }
        static int EnterChoosens()
        {
            Console.WriteLine("Cixis etmek ucun 0 secin");
            Console.WriteLine("Medicine elave etemek ucun 1 secin");
            Console.WriteLine("Add elilmis medicine gormek ucun 2  secin");
            int result = int.Parse(Console.ReadLine());
            return result;  
        }
        static (int,string,string,decimal) EnterMedDetails()
        {
            Console.WriteLine("Id ni dexil edin");
            int id= int.Parse(Console.ReadLine());
            Console.WriteLine("Name daxil et");
            string name = Console.ReadLine();
            Console.WriteLine("Producer daxil et");
            string producer = Console.ReadLine();
            Console.WriteLine("Price daxil et");
            decimal  price= decimal.Parse(Console.ReadLine());

            return(id,name,producer,price);
        }

    }
}
