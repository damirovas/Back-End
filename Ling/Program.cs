using System.ComponentModel;

namespace Ling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LING -- Language Integrated Query
            //DataBase tipli sorgularda istifade olunur
            // 2 cagirilma yolu var
            // 1)keywordlerle (from,select)
            //22)QueryExecute
            //where edib select etmek daha suretlidir ,
            // cunki diger turlu butun datalari getirib sonra sececek
            Product product1 = new Product("daraq", 99.99, 20);
            Product product2 = new Product("Kiko gloss", 27, 20);
            Product product3 = new Product("divage", 2, 20);
            Product product4 = new Product("Makaraon", 1, 20);
            Product product5 = new Product("Dish pastasi", 1.8, 20);
            Product product6 = new Product("Sampun", 8.9, 20);
            Product product7 = new Product("Cay", 12.99, 40);

            List<Product> products = new List<Product>();
            products.Add(product1);
            products.Add(product2);
            products.Add(product3);
            products.Add(product4);
            products.Add(product5);
            products.Add(product6);
            products.Add(product7);

            // var list<Res> result= Filter(products, "a", 20);
            //foreach (var result in results)
            //{
            //    Console.WriteLine(result);
            //}

            #region MyRegion
            //var query = from product in products
            //                //where product.Name.Contains('a')&&product.Price>3
            //            orderby product.Id
            //            orderby product.Name descending

            //            select (product.Id,
            //                    product.Name,
            //                    product.Price);


            //foreach (var item in query)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Region
            //var query = products.Where(p => p.Price > 4)
            //                     .Select(x => (x.Name, x.Price))
            //                     .OrderBy(x => x.Price )
            //                     .ToList();


            //foreach (var item in query)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
           

        }
        static List<(string Name, double Price)> Filter(IEnumerable<Product> products, string search, double min, double max)
        {
            return products
                .Where(x => x.Name.Contains(search, StringComparison.OrdinalIgnoreCase)) 
                .Where(x => x.Price < max && x.Price > min)
                .Select(x => (x.Name, x.Price)) 
                .ToList();
        }


    }
}
          
