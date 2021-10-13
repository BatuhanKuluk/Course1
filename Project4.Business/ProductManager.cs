using Project4.DataAccess;
using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project4.Business
{
    public class ProductManager
    {
        public List<Product> GetAll()
        {
            EFProductDal productDal = new EFProductDal();
            return productDal.GetAll();
        }
    }
}
