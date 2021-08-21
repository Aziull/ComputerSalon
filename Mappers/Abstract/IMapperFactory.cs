using Models;
using Types;

namespace Mappers.Abstract
{
    public interface IMapperFactory
    {
        IModelMapper<T> SelectMapper<T>(DetailType type) where T : class;
    }
}
