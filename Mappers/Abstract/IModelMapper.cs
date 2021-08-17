using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mappers.Abstract
{
    public interface IModelMapper<T> where T : Models.Detail
    {
       T ToModel(Detail detail);
    }
}
