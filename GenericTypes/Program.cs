namespace GenericTypes
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
            //DataControl strControl = new DataControl();
            //strControl.Add("Salam");
            //strControl.Add("necesen");
            //strControl.GetStr();
            //DataControl fruitControl = new DataControl();
            //Fruit fruit1 = new Fruit("alma");
            //Fruit fruit2 = new Fruit("armud");
            //fruitControl.Add(fruit1);
            //fruitControl.Add(fruit2);
            //fruitControl.GetFruit();

            DataControl<int> numConrol = new DataControl<int>();
            numConrol.Add(4);
            numConrol.Add(5);
            numConrol.Add(6);
            numConrol.Add(7);
            numConrol.Get();
            DataControl<string> strControl = new DataControl<string>();
            strControl.Add("Salam");
            strControl.Add("Necesen");
            strControl.Get();
            DataControl<Fruit> fruitControl = new DataControl<Fruit>();
            Fruit fruit1 = new Fruit("alma");
            Fruit fruit2 = new Fruit("armud");
            fruitControl.Add(fruit1);
            fruitControl.Add(fruit2);
            fruitControl.Get();
        }
    }
}
