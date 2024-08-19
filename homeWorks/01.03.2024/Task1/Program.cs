namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region IF ELSE
            //Console.WriteLine("Operator daxil edin");
            //string op = Console.ReadLine();
            //Console.WriteLine("Birinci Ededi daxil edin");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Ikinci Ededi daxil edin");
            //int num2 = int.Parse(Console.ReadLine());

            //if (op == "*")
            //{
            //    Console.WriteLine(num1 * num2);
            //}
            //else if (op == "+")
            //{
            //    Console.WriteLine(num1 + num2);
            //}
            //else if (op == "-")
            //{
            //    Console.WriteLine(num1 - num2);
            //}
            //else if (op == "/")
            //{
            //    Console.WriteLine(num1 / num2);
            //}
            //else if (op == "%")
            //{
            //    Console.WriteLine(num1 % num2);
            //}
            //else
            //{
            //    Console.WriteLine("Yanlis operator secimi");
            //}
            #endregion


            #region SWITCH CASE
            Console.WriteLine("Operator daxil edin");
            string op = Console.ReadLine();
            Console.WriteLine("Birinci Ededi daxil edin");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ikinci Ededi daxil edin");
            int num2 = int.Parse(Console.ReadLine());

            switch (op)
            {
                case "*":
                    Console.WriteLine(num1 * num2);
                    break;
                case "+":
                    Console.WriteLine(num1 + num2);
                    break;
                case "-":
                    Console.WriteLine(num1 - num2);
                    break;
                case "/":
                    Console.WriteLine(num1 / num2);
                    break;
                case "%":
                    Console.WriteLine(num1 % num2);
                    break;
                    default:
                    Console.WriteLine("Yanlis operator secimi");
                    break;
            }
            #endregion
        }
    }
 }

