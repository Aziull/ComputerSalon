using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Abstract
{
    interface IUnitOfWork
    {
        IDetailRepository DetailRepository { get; set; }
        IValueRepository ValueRepository { get; set; }
        IPropertyRepository PropertyRepository { get; set; }
        ITypeRepository TypeRepository { get; set; }
        ISystemUnitRepository SystemUnitRepository { get; set; }
        ISystemUnitDetailRepository SystemUnitDetailRepository { get; set; }

        Task SaveChanges();
    }
}
