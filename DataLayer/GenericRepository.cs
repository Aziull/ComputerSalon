

using DataLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
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
        public async Task AddAsync(T entity)
        {
            await table.AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(K key)
        {
            T obj = await table.FindAsync(key);
            table.Remove(obj);
            await context.SaveChangesAsync();
        }

        public async Task<IList<T>> GetAllAsync()
        {
            return await table.ToListAsync();
        }

        public async Task<T> GetAsync(K key)
        {
            return await table.FindAsync(key);
        }

        public async Task UpdataAsync(T entity)
        {
            this.context.Entry(entity).State = EntityState.Modified;
            await this.context.SaveChangesAsync();
        }
    }
}

