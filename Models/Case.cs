using System;
using Types;

namespace Models
{
    public class Case : Detail
    {
        public Tuple<int,int,int> MaxPowerSupplySize { get; set; }
        public string MotherboardTypeСompatibility { get; set; }
        public PowerSupplyType PowerSupplyTypeCompatybility { get; set; }


        public bool CheckMotherBoardСompatibility(Motherboard detail)
        {
            return MotherboardTypeСompatibility == detail.MotherboardType; 
        }
        public bool CheckPowerSupplyСompatibility(PowerSupply powerSupply)
        {

            return powerSupply.Size.Item1 <= MaxPowerSupplySize.Item1 &&
                powerSupply.Size.Item2 <= MaxPowerSupplySize.Item2 &&
                powerSupply.Size.Item3 <= MaxPowerSupplySize.Item3;
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
