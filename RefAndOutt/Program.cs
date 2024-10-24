namespace RefAndOutt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group group = new Group(1,"fzm239",3);
            group.AddStudent(new Student(1, "sema", "damirova"));
            group.AddStudent(new Student(2, "resul", "Mirzeyev"));
            group.GetStudents();

        }
    }
}
