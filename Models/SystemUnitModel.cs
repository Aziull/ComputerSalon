using Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class SystemUnitModel : BaseModel
    {
        public CaseModel Case { get; set; }
        public MotherboardModel Motherboard { get; set; }
        public PowerSupplyModel PowerSupply { get; set; }
        public ProcessorModel Prossesor { get; set; }
        public MemoryCardModel MemoryCard { get; set; }



    }
}
