using Models.Abstract;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace Models
{
    public class CaseModel : BaseModel
    {

        public MotherboardType MotherboardTypeСompatibility { get; set; }
        public PowerSupplyType PowerSupplyTypeCompatybility { get; set; }

        public bool CheckMotherBoardСompatibility(MotherboardType type)
        {
            return MotherboardTypeСompatibility == type; 
        }
        public bool CheckPowerSupplyСompatibility(PowerSupplyType type)
        {
            return PowerSupplyTypeCompatybility == type; 
        }
        public override string ToString()
        {
            return $"Id: {Id} | " +
                                  $"Name: {Name} | " +
                                  $"Price: {Price} | " +
                                  $"Compatibility motherboard: {MotherboardTypeСompatibility} | " +
                                  $"Compatibility power supply: {PowerSupplyTypeCompatybility}";
        }

    }
}
