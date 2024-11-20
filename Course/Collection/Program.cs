using System.Collections;
using System.Net.WebSockets;

namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Sema");
            arrayList.Add(true);
            arrayList.Insert(5,"sema");
            foreach (var elem in arrayList)
            {
                Console.WriteLine(elem);
            }


        }
    }
}
