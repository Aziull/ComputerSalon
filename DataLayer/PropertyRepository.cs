using DataLayer.Abstract;
using Entities;

namespace DataLayer
{
    public class PropertyRepository : GenericRepository<int,Property>, IPropertyRepository
    {
        public PropertyRepository(MainDbContext context) : base(context)
        {

        }
    }
}