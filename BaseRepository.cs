using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class BaseRepository<T> : Base where T : class
    {
        public virtual List<T> List()
        {
            return ctx.Set<T>().ToList();
        }
        public virtual void Add(T entity)
        {
            ctx.Set<T>().Add(entity);
            ctx.SaveChanges();
        }
        public virtual void Update(T entity)
        {
            ctx.Set<T>().Attach(entity);
            ctx.Entry(entity).State = EntityState.Modified;
            ctx.SaveChanges();
        }
        public virtual void Remove(int entityId)
        {
            T Entity = ctx.Set<T>().Find(entityId);
            
            ctx.SaveChanges();
            if (ctx.Entry(Entity).State == EntityState.Detached)
            {
                ctx.Set<T>().Attach(Entity);
            }
            ctx.Set<T>().Remove(Entity);
            ctx.SaveChanges();
        }
        public virtual T FindById(int EntityId)
        {
            return ctx.Set<T>().Find(EntityId);
        }
    }
}   