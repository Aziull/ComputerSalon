using DataLayer.Abstract;
using Entities;

namespace DataLayer
{
    public class TypeRepository : GenericRepository<int,Type>, ITypeRepository
    {
        public TypeRepository(MainDbContext context) :base(context)
        {

        }
    }
}