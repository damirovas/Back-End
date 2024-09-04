namespace Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine((int)OrderStatus.Pending);
            Console.WriteLine((OrderStatus)100);
        }
        enum OrderStatus 
        {
            Pending=100,
            Cargo,
            Delivered,
            Rejected
        }

    }
    internal class Student 
    {
        public string Name {  get; set; }
        public string LastName { get; set; }
        public Student(string name, string lastName)
        {
            Name = name;

            LastName = lastName;

        }
    }

}
