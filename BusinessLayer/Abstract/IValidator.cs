using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface IValidator
    {
        bool Validate(ISystemUnitHandler systemUnitHandler);
    }
}
