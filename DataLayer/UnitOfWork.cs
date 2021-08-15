using DataLayer.Abstract;
using System;
using System.Threading.Tasks;

namespace DataLayer
{
    public class UnitOfWork : IUnitOfWork
    {
       private readonly MainDbContext context;

        public IDetailRepository DetailRepository { get; set; }
        public IValueRepository ValueRepository { get; set; }
        public IPropertyRepository PropertyRepository { get; set; }
        public ITypeRepository TypeRepository { get; set; }
        public ISystemUnitRepository SystemUnitRepository { get; set; }
        public ISystemUnitDetailRepository SystemUnitDetailRepository { get; set; }

        public UnitOfWork(MainDbContext context)
        {
            this.context = context;

            DetailRepository = new DetailRepository(context);
            ValueRepository = new ValueRepository(context);
            PropertyRepository = new PropertyRepository(context);
            TypeRepository = new TypeRepository(context);
            SystemUnitRepository = new SystemUnitRepository(context);
            SystemUnitDetailRepository = new SystemUnitDetailRepository(context);
        }
        public async Task SaveChanges()
        {
            await context.SaveChangesAsync();
        }
    }
}
