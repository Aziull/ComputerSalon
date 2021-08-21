using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Abstract
{
     public interface IGenericRepository<K,T>
    {
        void Add(T entity);
        T Get(K key);
        IList<T> GetAll();
        void Updata(T entity);
        void Delete(K key);

    }
}
