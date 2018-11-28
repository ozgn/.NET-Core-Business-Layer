using Microsoft.EntityFrameworkCore;
using Shopping.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Shopping.Core.DataAccess.EntityFramework
{
    public class BaseRepository<TEntity,TContext>:IEntityRepository<TEntity> where TEntity:class,IEntity,new() where TContext:DbContext,new()
    {
        public TEntity Get(Expression<Func<TEntity,bool>> filter)
        {
            using (var context=new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetList(Expression<Func<TEntity,bool>> filter = null)
        {
            using (var context=new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList(); 
            }
        }

        public void Add(TEntity entity)
        {
            using (var context=new TContext())
            {
                context.Entry(entity).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Entry(entity).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
