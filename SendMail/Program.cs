namespace SendMail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmailContainer container = new EmailContainer();
            container.SendEmail("sdamirova2004@gmail.com");
           
        }
    }
}
