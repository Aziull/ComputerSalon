using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Abstract
{
     public interface IGenericRepository<K,T>
    {
        Task AddAsync(T entity);
        Task<T> GetAsync(K key);
        Task<IList<T>> GetAllAsync();
        Task UpdataAsync(T entity);
        Task DeleteAsync(K key);

    }
}
