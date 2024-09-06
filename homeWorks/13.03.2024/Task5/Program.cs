namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt1 = new DateTime(2004, 07, 2);
            DateTime dt2 = DateTime.Now;
            int dayDiff = int.Parse((dt2 - dt1).ToString("dd"));
            int year = dayDiff / 365;
            Console.WriteLine(year);
        }
    }
}
