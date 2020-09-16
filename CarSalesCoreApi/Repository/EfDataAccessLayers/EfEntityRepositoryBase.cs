using CarSalesCoreApi.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CarSalesCoreApi.Repository
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }
        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                : context.Set<TEntity>().Where(filter).ToList();
            }
        }
        public void Add(TEntity entity)
        {
            Process(entity, EntityState.Added);
        }
        public void Update(TEntity entity)
        {
            Process(entity,EntityState.Modified);
        }
        public void Delete(TEntity entity)
        {
            Process(entity, EntityState.Deleted);
        }
        private void Process(TEntity entity,EntityState entityState)
        {
            using (var context = new TContext())
            {
                var processedEntity = context.Entry(entity);
                processedEntity.State = entityState;
                context.SaveChanges();
            }
        }
    }
}
