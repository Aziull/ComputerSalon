using System;
using System.Collections.Generic;
using System.Text;

namespace Mappers.Abstract
{
    public interface IEntityMapper<TEntity,TModel>
    {
       TEntity ToEntity(TModel model);
    }
}
