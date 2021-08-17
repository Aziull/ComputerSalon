using Mappers.Abstract;
using Models;
using Types;

namespace Mappers.Factories
{
    public class MapperFactory : IMapperFactory
    {
        public IModelMapper<T> SellectMapper<T>(DetailType type) where T : Detail
        {
            switch (type)
            {
                case DetailType.Case:
                    return (IModelMapper<T>)new CaseMapper();
                case DetailType.MemoryCard:
                    return (IModelMapper<T>)new MemmoryCardMapper();
                case DetailType.Motherboard:
                    return (IModelMapper<T>)new MotherboardMapper();
                case DetailType.PowerSupply:
                    return (IModelMapper<T>)new PowerSupplyMapper();
                case DetailType.Processor:
                    return (IModelMapper<T>)new ProcessorMapper();
                default:
                    return null;
            }
        }
    }
}
