
using Models;
using Models.Abstract;
using System.Collections.Generic;
using Types;

namespace Models
{
    public  class InMemoryDB
    {
        
        public List<BaseModel> DetailsData { get; set; }


        private static InMemoryDB _instance;

        public static InMemoryDB Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new InMemoryDB();
                return _instance;
            }
        }

        private int _detailId = 0;
        public int DetailId
        {
            get
            {
                return ++_detailId;
            }
        }

        private InMemoryDB() 
        {

            DetailsData = new List<BaseModel>
            {
                new CaseModel{Id = DetailId, Name = "Zalman Z1", MotherboardTypeСompatibility=MotherboardType.ATX,PowerSupplyTypeCompatybility=PowerSupplyType.ATX , DetailType=DetailType.Case},
                new CaseModel{Id = DetailId, Name="Cooler Master", MotherboardTypeСompatibility=MotherboardType.MiniATX,PowerSupplyTypeCompatybility=PowerSupplyType.SFX, DetailType=DetailType.Case},
                new CaseModel{Id = DetailId, Name="AeroCool Aero-500", MotherboardTypeСompatibility=MotherboardType.MicroATX,PowerSupplyTypeCompatybility=PowerSupplyType.TFX,  DetailType=DetailType.Case},
                new CaseModel{Id = DetailId, Name="Thermaltake Core V21", MotherboardTypeСompatibility=MotherboardType.ATX,PowerSupplyTypeCompatybility=PowerSupplyType.TFX, DetailType=DetailType.Case},
                new ProcessorModel{Id = DetailId, Name="AMD Athlon II X2", SocketType=SocketType.AM3, Wattage=65 ,DetailType =DetailType.Processor},
                new ProcessorModel{Id = DetailId, Name="AMD Athlon II X3", SocketType=SocketType.AM3, Wattage=95,DetailType =DetailType.Processor},
                new ProcessorModel{Id = DetailId, Name="AMD Ryzen 7 3800X", SocketType=SocketType.AM4, Wattage=105,DetailType =DetailType.Processor},
                new ProcessorModel{Id = DetailId, Name="Intel Core i7-4770K", SocketType=SocketType.LGA1150, Wattage=84,DetailType =DetailType.Processor},
                new MotherboardModel{Id = DetailId, Name = "ASRock X570", MemoryCardTypeCompatibility = MemoryCardType.DDR4, MotherboardType=MotherboardType.ATX, SocketTypeCompatibility = SocketType.AM4 , DetailType=DetailType.Motherboard},
                new MotherboardModel{Id = DetailId, Name = "Biostar MCP6P", MemoryCardTypeCompatibility = MemoryCardType.DDR2, MotherboardType=MotherboardType.MicroATX, SocketTypeCompatibility=SocketType.AM3, DetailType=DetailType.Motherboard},
                new MotherboardModel{Id = DetailId, Name = "MSI H81M-P33", MemoryCardTypeCompatibility = MemoryCardType.DDR3, MotherboardType=MotherboardType.MiniATX, SocketTypeCompatibility=SocketType.LGA1150, DetailType=DetailType.Motherboard},
                new MotherboardModel{Id = DetailId, Name = "Asus M4N68T", MemoryCardTypeCompatibility = MemoryCardType.DDR3, MotherboardType=MotherboardType.ATX, SocketTypeCompatibility=SocketType.AM3, DetailType=DetailType.Motherboard},
                new MemoryCardModel{Id = DetailId, Name = "AMD DDR2-800", MemoryCardType=MemoryCardType.DDR2,Wattage=1 ,DetailType=DetailType.MemoryCard},
                new MemoryCardModel{Id = DetailId, Name = "Kingston DDR3-1333", MemoryCardType=MemoryCardType.DDR3,Wattage=2,DetailType=DetailType.MemoryCard},
                new MemoryCardModel{Id = DetailId, Name = "Goodram DDR3-1333", MemoryCardType=MemoryCardType.DDR3,Wattage=1,DetailType=DetailType.MemoryCard},
                new MemoryCardModel{Id = DetailId, Name = "HyperX DDR4-3200", MemoryCardType=MemoryCardType.DDR4,Wattage=2,DetailType=DetailType.MemoryCard},
                new PowerSupplyModel{Id = DetailId, Name="Modecom 400W", PowerSupplyType = PowerSupplyType.TFX, Wattage = 400 , DetailType=DetailType.PowerSupply},
                new PowerSupplyModel{Id = DetailId, Name="CHIEFTEC 650W", PowerSupplyType = PowerSupplyType.SFX, Wattage = 650 , DetailType=DetailType.PowerSupply},
                new PowerSupplyModel{Id = DetailId, Name="Vinga 400W", PowerSupplyType = PowerSupplyType.ATX, Wattage = 400 , DetailType=DetailType.PowerSupply},
                new PowerSupplyModel{Id = DetailId, Name="Inter-Tech 300W", PowerSupplyType = PowerSupplyType.TFX, Wattage = 300 , DetailType=DetailType.PowerSupply},

            };
        }
    }
}
