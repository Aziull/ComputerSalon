using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace Entity
{
    public class MemoryCardEntity : IBaseEntity
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }
        public double Wattage { get; set; }
        public string MemoryCardType { get; set; }

        public DetailType DetailType { get; set; }
    }
}
