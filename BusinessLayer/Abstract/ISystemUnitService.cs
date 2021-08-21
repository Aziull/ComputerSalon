using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ISystemUnitService
    {
        IList<SystemUnit> GetSystemUnits();

        void Save(SystemUnit SystemUnit);
    }
}
