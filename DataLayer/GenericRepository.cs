

using DataLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataLayer
{
    public class GenericRepository<K, T> : IGenericRepository<K, T> where T : class
    {
        protected readonly MainDbContext context;
        private readonly DbSet<T> table;

        public GenericRepository(MainDbContext context)
        {
            this.context = context;
            table = context.Set<T>();
        }
        public void Add(T entity)
        {
             table.Add(entity);
             context.SaveChanges();
        }

        public void Delete(K key)
        {
            T obj = table.Find(key);
            table.Remove(obj);
            context.SaveChanges();
        }

        public IList<T> GetAll()
        {
            return table.ToList();
        }

        public T Get(K key)
        {
            return table.Find(key);
        }

        public void Updata(T entity)
        {
           context.Entry(entity).State = EntityState.Modified;
           context.SaveChanges();
        }
    }
}

