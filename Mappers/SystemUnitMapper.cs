using Entities;
using Mappers.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mappers
{
    public class SystemUnitMapper : IEntityMapper<SystemUnit, Models.SystemUnit>
    {
        private readonly IEntityMapper<SystemUnitDetail, Models.Detail> entityMapper;
        public SystemUnitMapper()
        {
            entityMapper = new SystemUnitDetailMapper();
        }
        public SystemUnit ToEntity(Models.SystemUnit model)
        {
            SystemUnit systemUnit = new SystemUnit
            {
                Name = model.Name,
                SystemUnitDetails = model.Details.Select(detail => entityMapper.ToEntity(detail)).ToList()
            };
            return systemUnit;
        }
    }
}
