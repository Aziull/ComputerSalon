using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ISystemUnitService
    {
        Task<IList<SystemUnit>> GetSystemUnitsAsync();

        void Save(SystemUnit SystemUnit);
    }
}
