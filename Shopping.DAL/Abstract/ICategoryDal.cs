using Shopping.Core.DataAccess;
using Shopping.DB.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping.DAL.Abstract
{
    public interface ICategoryDal:IEntityRepository<Category>
    {
        //Custom operasyonlar icin
    }
}
