using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace Entity
{
    public class MotherboardEntity : IBaseEntity
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public string Name {get;set;}
        public string MotherboardType { get; set; }
        public string SocketTypeCompatibility { get; set; }
        public string MemoryCardTypeCompatibility { get; set; }

        public DetailType DetailType { get; set; }

    }
}
