using Entity;
using Mappers.Abstaract;
using Models;
using Types;
using System;
using System.Collections.Generic;
using System.Linq;
using Mappers.Factories;

namespace Mappers
{
    public class SystemUnitMapper
    {
        private InMemoryDB Data { get; } = InMemoryDB.Instance;
        private MapperFactory MapperFactory = new MapperFactory();
        /*private CaseMapper CaseMapper = new CaseMapper();
        private MemoryCardMapper MemoryCardMapper = new MemoryCardMapper();
        private MotherboardMapper MotherboardMapper = new MotherboardMapper();
        private PowerSupplyMapper PowerSupplyMapper = new PowerSupplyMapper();
        private ProcessorMapper ProcessorMapper = new ProcessorMapper();*/
        public SystemUnitEntity ToEntity(SystemUnitModel systemUnit)
        {
            return new SystemUnitEntity
            {
                Id = systemUnit.Id,
                Name = systemUnit.Name,
                CaseId = systemUnit.Case.Id,
                MemoryCardId = systemUnit.MemoryCard.Id,
                MotherboardId = systemUnit.Motherboard.Id,
                PowerSupplyId = systemUnit.PowerSupply.Id,
                ProssesorId = systemUnit.Prossesor.Id
            };
        }
     

        public SystemUnitModel ToModel(SystemUnitEntity systemUnit)
        {
            return new SystemUnitModel
            {
                Id = systemUnit.Id,
                Name = systemUnit.Name,
                Case = (CaseModel)MapperFactory.SelectMapper(DetailType.Case).ToModel(Data.CaseData.Find(box => box.Id == systemUnit.CaseId)),
                MemoryCard = (MemoryCardModel)MapperFactory.SelectMapper(DetailType.MemoryCard).ToModel(Data.MemoryCardData.Find(memoryCard => memoryCard.Id == systemUnit.MemoryCardId)),
                Motherboard = (MotherboardModel)MapperFactory.SelectMapper(DetailType.Motherboard).ToModel(Data.MotherboardData.Find(mother => mother.Id == systemUnit.MotherboardId)),
                PowerSupply = (PowerSupplyModel)MapperFactory.SelectMapper(DetailType.PowerSupply).ToModel(Data.PowerSupplyData.Find(powerSupply => powerSupply.Id == systemUnit.PowerSupplyId)),
                Prossesor = (ProcessorModel)MapperFactory.SelectMapper(DetailType.Processor).ToModel(Data.ProssesorData.Find(cpu => cpu.Id == systemUnit.ProssesorId))
            };
        }
    }
}
