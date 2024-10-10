namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] twoDim = new int[4, 4] { { 11,12,13,14 },
                                            { 51,61,17,18 },
                                            { 91,10,11,12 },
                                            { 13,14,15,16 } 
                                            };

            int result = 0;
            for (int i = 0; i < twoDim.GetLength(0); i++) 
            {
                if (i % 2 == 0) 
                {
                    for (int j = 0; j < twoDim.GetLength(1); j++) 
                    {
                        result += twoDim[i, j]; 
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
