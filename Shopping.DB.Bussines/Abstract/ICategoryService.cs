using Shopping.DB.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping.DB.Bussines.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
