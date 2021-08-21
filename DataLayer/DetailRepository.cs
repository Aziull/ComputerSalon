using DataLayer.Abstract;
using Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DetailRepository : GenericRepository<int, Detail>, IDetailRepository
    {
        public DetailRepository(MainDbContext context) :base(context)
        {

        }

        public IList<Detail> GetDetailsByType(int type)
        {
            return context.Details
                .Include(detail => detail.Values)
                .ThenInclude(value => value.Property)
                .Where(detail => detail.TypeId == type).ToList();
        }
    }
}