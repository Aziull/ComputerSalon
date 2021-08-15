using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataLayer.Abstract
{
    public interface IDetailRepository : IGenericRepository<int,Detail>
    {
        Task<IList<Detail>> GetDetailsByType(int type);
    }
}
