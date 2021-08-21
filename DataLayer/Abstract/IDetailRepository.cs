using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataLayer.Abstract
{
    public interface IDetailRepository : IGenericRepository<int,Detail>
    {
        IList<Detail> GetDetailsByType(int type);
    }
}
