using Shopping.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Shopping.Core.DataAccess
{
    // T class olmalı ve IEntity'den implemente edilmiş olmalı ve newlenebilir.
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        T Get(Expression<Func<T,bool>> filter=null);

        List<T> GetList(Expression<Func<T,bool>> filter=null);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

    }
}
