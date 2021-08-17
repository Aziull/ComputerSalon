using Models;
using Types;

namespace Mappers.Abstract
{
    public interface IMapperFactory
    {
        IModelMapper<T> SellectMapper<T>(DetailType type) where T : Detail;
    }
}
