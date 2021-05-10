using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace Entity
{
    public class CaseEntity : IBaseEntity
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }
        public string MotherboardTypeСompatibility { get; set; }
        public string PowerSupplyTypeCompatybility { get; set; }

        public DetailType DetailType { get; set; }

       
    }
}
