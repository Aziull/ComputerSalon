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
        public IValidator Next { get; set; }

        public bool Validate(ISingleUnitService systemUnit)
        { 
            var powerSupply = (PowerSupply)systemUnit.GetDetailByType(DetailType.PowerSupply).FirstOrDefault() ;
            var consumers = systemUnit.GetWattageConsumers();

            if (!powerSupply.IsEnoughPower(consumers))
                return false;
            return Next == null ? true : Next.Validate(systemUnit);
        }
    }
}
