namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StatusCode status = StatusCode.OK;
            Console.WriteLine($"Status code for OK: {(int)status}");

            status = StatusCode.Redirect;
            Console.WriteLine($"Status code for Redirect: {(int)status}");

            status = StatusCode.BadRequest;
            Console.WriteLine($"Status code for BadRequest: {(int)status}");

            status = StatusCode.NotFound;
            Console.WriteLine($"Status code for NotFound: {(int)status}");

            status = StatusCode.Error;
            Console.WriteLine($"Status code for Error: {(int)status}");
        }
    }
    enum StatusCode
    {
        OK=200,
        Redirect=301,
        BadRequest=400,
        NotFound=404,
        Error=500,
    }

}
