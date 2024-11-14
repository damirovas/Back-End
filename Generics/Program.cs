namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DataControl dataControl = new DataControl();
            //dataControl.Add(5);
            //dataControl.Add(6);
            //dataControl.Add(7);
            //dataControl.Get();
           // DataControl <int> numControl = new DataControl<int>();
           // numControl.Add(1);
           // numControl.Add(2);
           // numControl.Add(3);
           // numControl.Add(4);
           // numControl.Get();
           // DataControl <string> strControl = new DataControl<string>();
           // strControl.Add("salam");
           // strControl.Add("dfv");
           // strControl.Get();
           //DataControl <Fruit> fruitControl = new DataControl<Fruit>();
           // Fruit fruit1= new Fruit("alma");
           // fruitControl.Add(fruit1);
           // Fruit fruit2 = new Fruit("Armud");
           // fruitControl.Add(fruit2);
           // fruitControl.Get();

            DataControl <int ,string > dataControl = new DataControl<int ,string>();
            dataControl.Add(1, "salam");
            dataControl.Add(2, "resul");
            dataControl.Get();
            DataControl<Fruit,string> fruitControl = new DataControl<Fruit,string> ();
            Fruit fruit1 = new Fruit("alma");
            fruitControl.Add(fruit1, "first");
            Fruit fruit2 = new Fruit("armud");
            fruitControl.Add(fruit2, "second");
            fruitControl.Get();

        }
    }
}
