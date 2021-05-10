using Models.Abstract;
using Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PowerSupplyModel : BaseModel
    {
        public double Wattage { get; set; }
        public PowerSupplyType PowerSupplyType { get; set; }

        public double CalculateSystemWattage(double ProcessorWattage, double MemoryCardWattage)
        {
            return ProcessorWattage + MemoryCardWattage;
        }

        public override string ToString()
        {
            return $"Id: {Id} | " +
                                  $"Name: {Name} | " +
                                  $"Price: {Price} " +
                                  $"| Wattage: {Wattage} | " +
                                  $"Power supply type: {PowerSupplyType}";
        }
    }
}
