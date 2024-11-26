using System.Security.Cryptography.X509Certificates;

namespace D2
{
    internal class Program
    {
        public delegate int Math(int num1,int num2);
        public delegate string Message(string message);
        static void Main(string[] args)
        {
            #region MyRegion
            //Math math = new Math(Sum);
            //math += Multi;
            //math += Diff;
            //math += Divide;
            //foreach (Math m in math.GetInvocationList())
            //{
            //    Console.WriteLine(m(3, 8));
            //}
            //math += (num1, num2) =>
            //{
            //    int result = num1 * num2 - 10;
            //    return result;
            //};
            //math.Invoke(3, 8);
            //Message message = GetMessage;
            //Console.WriteLine(message.Invoke("salam"));
            #endregion

            #region Func
            //Func<int, int> func = Factorial;
            //Console.WriteLine(func.Invoke(5));
            #endregion

            #region Action
            Action<int, int> action = Sum;
            #endregion

        }
        
        static int Factorial(int num)
        {
            int result = 1;
            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }
            return result;
        }
        static int Sum(int num1,int num2)=>num2+num1;
        static int Multi(int num1, int num2) => num1 * num2;
        static int Diff (int num1,int num2)=> num1 - num2;
        static int Divide (int num1, int num2) => num1 / num2;
        static string GetMessage(string message) => message;
    }
}
