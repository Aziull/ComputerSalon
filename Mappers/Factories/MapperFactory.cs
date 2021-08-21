using Mappers.Abstract;
using Models;
using Types;

namespace Mappers.Factories
{
    public class MapperFactory : IMapperFactory
    {

        public IModelMapper<T> SelectMapper<T>(DetailType type) where T : class
        {

            switch (type)
            {
                case DetailType.Case:
                    var t = new CaseMapper();
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
