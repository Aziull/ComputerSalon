using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mappers.Abstract
{
    public interface IModelMapper<T> where T : class
    {
       T ToModel(Detail detail);
    }
}
