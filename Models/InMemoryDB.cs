using System.Collections.Generic;
using Types;

namespace Models
{
    public  class InMemoryDB
    {
        
        public List<Detail> DetailsData { get; set; }


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
            var size = new System.Tuple<int, int, int>(10, 20, 30);
            DetailsData = new List<Detail>
            {
                new Case{Id = DetailId, Name = "Zalman Z1", MotherboardTypeСompatibility="ATX",MaxPowerSupplySize= size , Type=DetailType.Case},
                new Case{Id = DetailId, Name="Cooler Master", MotherboardTypeСompatibility="MiniATX",MaxPowerSupplySize=size , Type=DetailType.Case},
                new Case{Id = DetailId, Name="AeroCool Aero-500", MotherboardTypeСompatibility="MicroATX",MaxPowerSupplySize=size ,  Type=DetailType.Case},
                new Case{Id = DetailId, Name="Thermaltake Core V21", MotherboardTypeСompatibility="ATX",MaxPowerSupplySize=size, Type=DetailType.Case},
                new Processor{Id = DetailId, Name="AMD Athlon II X2", SocketType="AM3", Wattage=65 ,Type =DetailType.Processor},
                new Processor{Id = DetailId, Name="AMD Athlon II X3", SocketType="AM3", Wattage=95,Type =DetailType.Processor},
                new Processor{Id = DetailId, Name="AMD Ryzen 7 3800X", SocketType="AM4", Wattage=105,Type =DetailType.Processor},
                new Processor{Id = DetailId, Name="Intel Core i7-4770K", SocketType="LGA1150", Wattage=84,Type =DetailType.Processor},
                new Motherboard{Id = DetailId, Name = "ASRock X570", MemoryCardTypeCompatibility = "DDR4", MotherboardType="ATX", SocketTypeCompatibility = "AM4" , Type=DetailType.Motherboard},
                new Motherboard{Id = DetailId, Name = "Biostar MCP6P", MemoryCardTypeCompatibility = "DDR2", MotherboardType="MicroATX", SocketTypeCompatibility="AM3", Type=DetailType.Motherboard},
                new Motherboard{Id = DetailId, Name = "MSI H81M-P33", MemoryCardTypeCompatibility = "DDR3", MotherboardType="MiniATX", SocketTypeCompatibility="LGA1150", Type=DetailType.Motherboard},
                new Motherboard{Id = DetailId, Name = "Asus M4N68T", MemoryCardTypeCompatibility = "DDR4", MotherboardType="ATX", SocketTypeCompatibility="AM3", Type=DetailType.Motherboard},
                new MemoryCard{Id = DetailId, Name = "AMD DDR2-800", MemoryCardType="DDR4",Wattage=1 ,Type=DetailType.MemoryCard},
                new MemoryCard{Id = DetailId, Name = "Kingston DDR3-1333", MemoryCardType="DDR2",Wattage=2,Type=DetailType.MemoryCard},
                new MemoryCard{Id = DetailId, Name = "Goodram DDR3-1333", MemoryCardType="DDR4",Wattage=1,Type=DetailType.MemoryCard},
                new MemoryCard{Id = DetailId, Name = "HyperX DDR4-3200", MemoryCardType="DDR3",Wattage=2,Type=DetailType.MemoryCard},
                new PowerSupply{Id = DetailId, Name="Modecom 400W",  Size = size, Power = 400 , Type=DetailType.PowerSupply},
                new PowerSupply{Id = DetailId, Name="CHIEFTEC 650W",  Size = size, Power = 650 , Type=DetailType.PowerSupply},
                new PowerSupply{Id = DetailId, Name="Vinga 400W",  Size = size, Power = 400 , Type=DetailType.PowerSupply},
                new PowerSupply{Id = DetailId, Name="Inter-Tech 300W",  Size = size, Power = 300 , Type=DetailType.PowerSupply},

            };
        }
    }
}
