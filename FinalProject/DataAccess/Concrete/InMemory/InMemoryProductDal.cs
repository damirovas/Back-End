using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{ProductId=1,
                            CategoryId=1,
                            ProductName="Bardak",
                            UnitPrice=15,
                            UnitsInStock=15
                            },
                new Product{ProductId=2,
                            CategoryId=1,
                            ProductName="Kamera",
                            UnitPrice=500,
                            UnitsInStock=2
                            },
                new Product{ProductId=3,
                            CategoryId=2,
                            ProductName="Iphone16",
                            UnitPrice=2500,
                            UnitsInStock=20
                            },
                new Product{ProductId=4,
                            CategoryId=2,
                            ProductName="Mouse",
                            UnitPrice=25,
                            UnitsInStock=9
                            },
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //Product productToDelete = null; //new product yazmaq olmaz
            //foreach(Product p in _products)
            //{
            //    if(product.ProductId == p.ProductId)
            //    {
            //        productToDelete = p;
            //    }
            //}
            //productToDelete = _products.SingleOrDefault(p=>p.ProductId==product.ProductId);
            //_products.Remove(product); hec vaxt islemir
            //soru
            // _products.Remove(productToDelete);
            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId==product.ProductId);


        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetByCategory(int CategorId)
        {
         return _products.Where(p=>p.CategoryId==CategorId).ToList(); 
            

        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p=>p.ProductId==product.ProductId);
            productToUpdate.ProductName= product.ProductName; 
            productToUpdate.CategoryId= product.CategoryId;
            productToUpdate.UnitPrice= product.UnitPrice;
            productToUpdate.UnitsInStock= product.UnitsInStock;
           
        }
    }
}
