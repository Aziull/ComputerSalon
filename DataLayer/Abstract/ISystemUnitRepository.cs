using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataLayer.Abstract
{
    public interface ISystemUnitRepository : IGenericRepository<int, SystemUnit>
    {
        Task<IList<SystemUnit>> GetAllFullSystemUnit();
    }
}
