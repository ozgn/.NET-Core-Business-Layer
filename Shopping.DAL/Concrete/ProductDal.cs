using Shopping.Core.DataAccess.EntityFramework;
using Shopping.DAL.Abstract;
using Shopping.DB.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping.DAL.Concrete
{
    public class ProductDal:BaseRepository<Product,ApplicationContext>,IProductDal
    {

    }
}
