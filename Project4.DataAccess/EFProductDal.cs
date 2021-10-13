using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project4.DataAccess
{
    public class EFProductDal : IProductDal
    {
        List<Product> _products;
        public EFProductDal()
        {
            _products = new List<Product>
            {
                new Product {ProductId=1,ProductName="Dell EF",QuantityPerUnits="32 GB Ram",UnitPrice=2000,UnitInStock=5},
                new Product {ProductId=2,ProductName="Asus EF",QuantityPerUnits="32 GB Ram",UnitPrice=2000,UnitInStock=2},
                new Product {ProductId=3,ProductName="Casper EF",QuantityPerUnits="32 GB Ram",UnitPrice=2000,UnitInStock=0},
                new Product {ProductId=4,ProductName="Lenova EF",QuantityPerUnits="32 GB Ram",UnitPrice=2000,UnitInStock=1},
                new Product {ProductId=5,ProductName="HP EF",QuantityPerUnits="32 GB Ram",UnitPrice=2000,UnitInStock=5}
            };
        }
        public void Add(Product product)
        {
            Console.WriteLine("EF ile Eklendi");
        }

        public List<Product> GetAll()
        {
            return _products;
        }
    }
}
