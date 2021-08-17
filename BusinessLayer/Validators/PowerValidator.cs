using BusinessLayer.Abstract;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Types;

namespace BusinessLayer.Validators
{
    public class PowerValidator : IValidator
    {

        public bool Validate(ISystemUnitHandler systemUnitHandler)
        { 
            var powerSupply = (PowerSupply)systemUnitHandler.GetDetailByType(DetailType.PowerSupply).Select(detail => detail as Detail).FirstOrDefault() ;
            var consumers = systemUnitHandler.GetWattageConsumers();

            if (!powerSupply.IsEnoughPower(consumers))
                return false;
            return true;
        }
    }
}
