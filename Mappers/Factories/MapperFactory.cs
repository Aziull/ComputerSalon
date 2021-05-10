
using Mappers.Abstaract;
using System;
using Types;

namespace Mappers.Factories
{
    public class MapperFactory
    {
        public IBaseMapper SelectMapper(DetailType type)
        {
            switch (type)
            {
                case DetailType.Case:
                    return new CaseMapper();
                case DetailType.Motherboard:
                    return new MotherboardMapper();
                case DetailType.PowerSupply:
                    return new PowerSupplyMapper();
                case DetailType.MemoryCard:
                    return new MemoryCardMapper();
                case DetailType.Processor:
                    return new ProcessorMapper();
                default:
                    throw new InvalidOperationException();
            }
            
        }
    }
}
