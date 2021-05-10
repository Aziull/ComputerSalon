using Models.Abstract;
using Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class MemoryCardModel : BaseModel
    {
        public double Wattage { get; set; }
        public MemoryCardType MemoryCardType { get; set; }

        public override string ToString()
        {
            return $"Id: {Id} | " +
                                  $"Name: {Name} | " +
                                  $"Price: {Price} | " +
                                  $"Memory card type: {MemoryCardType} | " +
                                  $"Wattage: {Wattage}";
        }
    }
}
