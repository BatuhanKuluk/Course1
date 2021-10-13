using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project4.DataAccess
{
    public class ProductDal
    {
        List<Product> _products;
        public ProductDal()
        {
            _products = new List<Product>
            {
                new Product {ProductId=1,ProductName="Dell",QuantityPerUnits="32 GB Ram",UnitPrice=2000,UnitInStock=5},
                new Product {ProductId=2,ProductName="Asus",QuantityPerUnits="32 GB Ram",UnitPrice=2000,UnitInStock=2},
                new Product {ProductId=3,ProductName="Casper",QuantityPerUnits="32 GB Ram",UnitPrice=2000,UnitInStock=0},
                new Product {ProductId=4,ProductName="Lenova",QuantityPerUnits="32 GB Ram",UnitPrice=2000,UnitInStock=1},
                new Product {ProductId=5,ProductName="HP",QuantityPerUnits="32 GB Ram",UnitPrice=2000,UnitInStock=5}
            };
        }
        public List<Product> GetAll()
        {
            return _products;
        }
    }
}
