using BusinessLayer.Abstract;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Types;

namespace BusinessLayer.Validators
{
    public class SizeValidator : IValidator
    {
        public IValidator Next { get ; set ; }

        public bool Validate(ISingleUnitService systemUnit)
        {
            var powerSupply = (PowerSupply)systemUnit.GetDetailByType(DetailType.PowerSupply).FirstOrDefault();
            var unitCase = (Case)systemUnit.GetDetailByType(DetailType.Case).FirstOrDefault();

            if (!unitCase.CheckPowerSupplyСompatibility(powerSupply)) 
                return false;
            return Next == null ? true : Next.Validate(systemUnit);
        }
    }
}
