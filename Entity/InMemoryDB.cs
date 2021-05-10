using Entity.Abstract;
using System.Collections.Generic;
using Types;

namespace Entity
{
    public  class InMemoryDB
    {
        public List<CaseEntity> CaseData { get; set; }
        public List<MotherboardEntity> MotherboardData { get; set; }
        public List<PowerSupplyEntity> PowerSupplyData { get; set; }
        public List<MemoryCardEntity> MemoryCardData { get; set; }
        public List<ProcessorEntity> ProssesorData { get; set; }
        public List<SystemUnitEntity> SystemUnitData { get; set; }

        public List<IBaseEntity> DetailsData { get; set; }


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
        private int _caseId = 0;
        public int CaseId
        {
            get => ++_caseId;
        }

        private int _motherboardId = 0; 
        public int MotherboarId
        {
            get 
            {
                return ++_motherboardId;
            }
        }
        
        
        private int _powerSupplyId = 0; 
        public int PowerSupplyId
        {
            get 
            {
                return ++_powerSupplyId;
            }
        }
        
        private int _memoryCardId = 0; 
        public int MemoryCardId
        {
            get 
            {
                return ++_memoryCardId;
            }
        }
        
        private int _prossesorId = 0; 
        public int ProssesorId
        {
            get 
            {
                return ++_prossesorId;
            }
        }
        
        private int _systemUnitId = 0; 
        public int SystemUnitId
        {
            get 
            {
                return ++_systemUnitId;
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
            CaseData = new List<CaseEntity>
           {
               new CaseEntity{Id = CaseId, Name = "Zalman Z1", MotherboardTypeСompatibility="ATX",PowerSupplyTypeCompatybility="ATX" , DetailType=DetailType.Case},
               new CaseEntity{Id = CaseId, Name="Cooler Master", MotherboardTypeСompatibility="MiniATX",PowerSupplyTypeCompatybility="SFX", DetailType=DetailType.Case},
               new CaseEntity{Id = CaseId, Name="AeroCool Aero-500", MotherboardTypeСompatibility="MicroATX",PowerSupplyTypeCompatybility="TFX", DetailType=DetailType.Case},
               new CaseEntity{Id = CaseId, Name="Thermaltake Core V21", MotherboardTypeСompatibility="ATX",PowerSupplyTypeCompatybility="TFX", DetailType=DetailType.Case}
           };
            MotherboardData = new List<MotherboardEntity>
            {
                new MotherboardEntity{Id = MotherboarId, Name = "ASRock X570", MemoryCardTypeCompatibility = "DDR4", MotherboardType="ATX", SocketTypeCompatibility="AM4" , DetailType = DetailType.Motherboard},
                new MotherboardEntity{Id = MotherboarId, Name = "Biostar MCP6P", MemoryCardTypeCompatibility = "DDR2", MotherboardType="MicroATX", SocketTypeCompatibility="AM3",DetailType = DetailType.Motherboard},
                new MotherboardEntity{Id = MotherboarId, Name = "MSI H81M-P33", MemoryCardTypeCompatibility = "DDR3", MotherboardType="MiniATX", SocketTypeCompatibility="LGA1150",DetailType = DetailType.Motherboard},
                new MotherboardEntity{Id = MotherboarId, Name = "Asus M4N68T", MemoryCardTypeCompatibility = "DDR3", MotherboardType="ATX", SocketTypeCompatibility="AM3",DetailType = DetailType.Motherboard},

            };
            PowerSupplyData = new List<PowerSupplyEntity>
            {
                new PowerSupplyEntity{Id = PowerSupplyId, Name="Modecom 400W", PowerSupplyType = "TFX", Wattage = 400 , DetailType=DetailType.PowerSupply},
                new PowerSupplyEntity{Id = PowerSupplyId, Name="CHIEFTEC 650W", PowerSupplyType = "SFX", Wattage = 650 ,DetailType=DetailType.PowerSupply},
                new PowerSupplyEntity{Id = PowerSupplyId, Name="Vinga 400W", PowerSupplyType = "ATX", Wattage = 400 , DetailType=DetailType.PowerSupply},
                new PowerSupplyEntity{Id = PowerSupplyId, Name="Inter-Tech 300W", PowerSupplyType = "TFX", Wattage = 300 , DetailType=DetailType.PowerSupply}
            };
            MemoryCardData = new List<MemoryCardEntity> { 
                new MemoryCardEntity{Id = MemoryCardId, Name = "AMD DDR2-800", MemoryCardType="DDR2",Wattage=1 ,DetailType=DetailType.MemoryCard},
                new MemoryCardEntity{Id = MemoryCardId, Name = "Kingston DDR3-1333", MemoryCardType="DDR3",Wattage=2,DetailType=DetailType.MemoryCard},
                new MemoryCardEntity{Id = MemoryCardId, Name = "Goodram DDR3-1333", MemoryCardType="DDR3",Wattage=1,DetailType=DetailType.MemoryCard},
                new MemoryCardEntity{Id = MemoryCardId, Name = "HyperX DDR4-3200", MemoryCardType="DDR4",Wattage=2,DetailType=DetailType.MemoryCard},
            };
            ProssesorData = new List<ProcessorEntity>
            {
                new ProcessorEntity{Id = ProssesorId, Name="AMD Athlon II X2", SocketType="AM3", Wattage=65 ,DetailType =DetailType.Processor},
                new ProcessorEntity{Id = ProssesorId, Name="AMD Athlon II X3", SocketType="AM3", Wattage=95,DetailType =DetailType.Processor},
                new ProcessorEntity{Id = ProssesorId, Name="AMD Ryzen 7 3800X", SocketType="AM4", Wattage=105,DetailType =DetailType.Processor},
                new ProcessorEntity{Id = ProssesorId, Name="Intel Core i7-4770K", SocketType="LGA1150", Wattage=84,DetailType =DetailType.Processor}
            };
            SystemUnitData = new List<SystemUnitEntity> { };

            DetailsData = new List<IBaseEntity>
            {
                new CaseEntity{Id = DetailId, Name = "Zalman Z1", MotherboardTypeСompatibility="ATX",PowerSupplyTypeCompatybility="ATX" , DetailType=DetailType.Case},
               new CaseEntity{Id = DetailId, Name="Cooler Master", MotherboardTypeСompatibility="MiniATX",PowerSupplyTypeCompatybility="SFX", DetailType=DetailType.Case},
               new CaseEntity{Id = DetailId, Name="AeroCool Aero-500", MotherboardTypeСompatibility="MicroATX",PowerSupplyTypeCompatybility="TFX",  DetailType=DetailType.Case},
               new CaseEntity{Id = DetailId, Name="Thermaltake Core V21", MotherboardTypeСompatibility="ATX",PowerSupplyTypeCompatybility="TFX", DetailType=DetailType.Case},
               new ProcessorEntity{Id = DetailId, Name="AMD Athlon II X2", SocketType="AM3", Wattage=65 ,DetailType =DetailType.Processor},
                new ProcessorEntity{Id = DetailId, Name="AMD Athlon II X3", SocketType="AM3", Wattage=95,DetailType =DetailType.Processor},
                new ProcessorEntity{Id = DetailId, Name="AMD Ryzen 7 3800X", SocketType="AM4", Wattage=105,DetailType =DetailType.Processor},
                new ProcessorEntity{Id = DetailId, Name="Intel Core i7-4770K", SocketType="LGA1150", Wattage=84,DetailType =DetailType.Processor},
                new MotherboardEntity{Id = DetailId, Name = "ASRock X570", MemoryCardTypeCompatibility = "DDR4", MotherboardType="ATX", SocketTypeCompatibility="AM4" , DetailType=DetailType.Motherboard},
                new MotherboardEntity{Id = DetailId, Name = "Biostar MCP6P", MemoryCardTypeCompatibility = "DDR2", MotherboardType="MicroATX", SocketTypeCompatibility="AM3", DetailType=DetailType.Motherboard},
                new MotherboardEntity{Id = DetailId, Name = "MSI H81M-P33", MemoryCardTypeCompatibility = "DDR3", MotherboardType="MiniATX", SocketTypeCompatibility="LGA1150", DetailType=DetailType.Motherboard},
                new MotherboardEntity{Id = DetailId, Name = "Asus M4N68T", MemoryCardTypeCompatibility = "DDR3", MotherboardType="ATX", SocketTypeCompatibility="AM3", DetailType=DetailType.Motherboard},
                new MemoryCardEntity{Id = DetailId, Name = "AMD DDR2-800", MemoryCardType="DDR2",Wattage=1 ,DetailType=DetailType.MemoryCard},
                new MemoryCardEntity{Id = DetailId, Name = "Kingston DDR3-1333", MemoryCardType="DDR3",Wattage=2,DetailType=DetailType.MemoryCard},
                new MemoryCardEntity{Id = DetailId, Name = "Goodram DDR3-1333", MemoryCardType="DDR3",Wattage=1,DetailType=DetailType.MemoryCard},
                new MemoryCardEntity{Id = DetailId, Name = "HyperX DDR4-3200", MemoryCardType="DDR4",Wattage=2,DetailType=DetailType.MemoryCard},
                new PowerSupplyEntity{Id = DetailId, Name="Modecom 400W", PowerSupplyType = "TFX", Wattage = 400 , DetailType=DetailType.PowerSupply},
                new PowerSupplyEntity{Id = DetailId, Name="CHIEFTEC 650W", PowerSupplyType = "SFX", Wattage = 650 , DetailType=DetailType.PowerSupply},
                new PowerSupplyEntity{Id = DetailId, Name="Vinga 400W", PowerSupplyType = "ATX", Wattage = 400 , DetailType=DetailType.PowerSupply},
                new PowerSupplyEntity{Id = DetailId, Name="Inter-Tech 300W", PowerSupplyType = "TFX", Wattage = 300 , DetailType=DetailType.PowerSupply},
                 
                
            };
        }
    }
}
