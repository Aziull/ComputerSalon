using Entities;
using Mappers.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mappers
{
    public class SystemUnitDetailMapper : IEntityMapper<SystemUnitDetail, Models.Detail>
    {
        public SystemUnitDetail ToEntity(Models.Detail model)
        {
            SystemUnitDetail systemUnitDetail = new SystemUnitDetail
            {
                DetailId = model.Id
            };
            return systemUnitDetail;
        }
    }
}
