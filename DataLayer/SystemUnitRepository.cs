using DataLayer.Abstract;
using Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataLayer
{
    public class SystemUnitRepository : GenericRepository<int, SystemUnit>, ISystemUnitRepository
    {
        public SystemUnitRepository(MainDbContext context) : base(context)
        {

        }
        public async Task<IList<SystemUnit>> GetAllFullSystemUnit()
        {
            return await context.SystemUnits
                .Include(systemUnit => systemUnit.SystemUnitDetails)
                .ThenInclude(systemUnitDetail => systemUnitDetail.Detail)
                .ToArrayAsync();
        }
    }
}