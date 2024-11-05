using System.Data;

namespace Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataControl dataControl = new DataControl();
            dataControl.Add(5);
            dataControl.Add(6);
            dataControl.Add(7);
            dataControl.Get();
            
        }
    }
}
