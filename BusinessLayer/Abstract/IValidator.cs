using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface IValidator
    {
        //Next
        IValidator Next { get; set; }
        bool Validate(ISingleUnitService systemUnitHandler);
    }
}
