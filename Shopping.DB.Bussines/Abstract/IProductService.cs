
using Shopping.DB.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping.DB.Bussines.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetByCategory(int categoryId);
        void Add(Product product);
        void Update(Product product);
        void Delete(int productId);

    }
}
