using DataLayer.Abstract;
using Entities;

namespace DataLayer
{
    public class ValueRepository : GenericRepository<int, Value>, IValueRepository
    {
        public ValueRepository(MainDbContext context) : base(context)
        {

        }
    }
}