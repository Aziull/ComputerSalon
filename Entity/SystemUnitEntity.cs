using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace Entity
{
    public class SystemUnitEntity : IBaseEntity
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }
        public int CaseId { get; set; }
        public int MotherboardId { get; set; }
        public int PowerSupplyId { get; set; }
        public int ProssesorId { get; set; }
        public int MemoryCardId { get; set; }

        public DetailType DetailType { get; set; }
    }
}
