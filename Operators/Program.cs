namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Ededi daxil edin");
            //int num = int.Parse(Console.ReadLine());
            //if(num > 0)
            //{
            //    Console.WriteLine($"{num} musbettir");
            //}
            //else if(num < 0)
            //{
            //    Console.WriteLine($"{num} menfidir");
            //}
            //else
            //{
            //    Console.WriteLine("eded sifirdir");
            //}

            //Console.WriteLine("Ededi daxil edin");
            //int num= int.Parse(Console.ReadLine());
            //if (num % 2 == 0 && num % 3 == 0) {
            //    Console.WriteLine($"{num} 6 ya bolunur");
            //} else if (num % 2 == 0) 
            //{
            //    Console.WriteLine($"{num} 2ya bolunur");
            //}
            //else if (num % 3 == 0)
            //{
            //    Console.WriteLine($"{num} 3ya bolunur");
            //}
            //else
            //{
            //    Console.WriteLine($"{num} ne ikiye nede 3e bolunmur");
            //}

            //Console.WriteLine("Ededi daxil edin");
            //int num = int.Parse(Console.ReadLine());
            //string result = num % 2 == 0 && num % 3 == 0 ? " 6 ya bolunur" :
            //    (num % 3 == 0 ? $"{num} e bolunur" :
            //    (num % 2 == 0 ? "2 ye bolunur" :
            //    ("eded ne ikiye nede 3e bolunmur")));
            //    Console.WriteLine(result);

            #region TASK
            Console.WriteLine("Alinan mehsul sayi");
            int mehsulSayi = int.Parse(Console.ReadLine());
            Console.WriteLine("Mehsulun alis giymeti");
            int mehsulQiymeti = int.Parse(Console.ReadLine());
            Console.WriteLine("Satilan mehsul sayi");
            int satilanSayi = int.Parse(Console.ReadLine());
            Console.WriteLine("Satilan mehsulun qiymeti");
            int satilanQiymet = int.Parse(Console.ReadLine());

            int result = (satilanQiymet * satilanSayi) - (mehsulQiymeti * mehsulSayi);

            if (result > 0)
            {
                Console.WriteLine($"{result} manat kardasan");
            }
            else if (result < 0)
            {
                Console.WriteLine($"{result} manat zererdesen");
            }
            else
            {
                Console.WriteLine("yakayi zor kurtardin :) ");
            }

            #endregion


        }
    }
}
