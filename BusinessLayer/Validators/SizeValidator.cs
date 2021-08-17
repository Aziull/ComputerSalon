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
        public bool Validate(ISystemUnitHandler systemUnitHandler)
        {
            var powerSupply = (PowerSupply)systemUnitHandler.GetDetailByType(DetailType.PowerSupply).Select(detail => detail as Detail).FirstOrDefault();
            var unitCase = (Case)systemUnitHandler.GetDetailByType(DetailType.Case).Select(detail => detail as Detail).FirstOrDefault();

            if (!unitCase.CheckPowerSupplyСompatibility(powerSupply)) 
                return false;
            return true;
        }
    }
}
