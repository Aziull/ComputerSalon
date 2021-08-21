using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataLayer.Abstract
{
    public interface ISystemUnitRepository : IGenericRepository<int, SystemUnit>
    {
        IList<SystemUnit> GetAllFullSystemUnit();
    }
}
