using Shopping.DAL.Abstract;
using Shopping.DB.Bussines.Abstract;
using Shopping.DB.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping.DB.Bussines.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }
    }
}
