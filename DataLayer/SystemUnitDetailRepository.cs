using DataLayer.Abstract;
using Entities;

namespace DataLayer
{
    public class SystemUnitDetailRepository : GenericRepository<int,SystemUnitDetail>, ISystemUnitDetailRepository
    {
        public SystemUnitDetailRepository(MainDbContext context) : base(context)
        {

        }
    }
}