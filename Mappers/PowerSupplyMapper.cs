using Entity;
using Entity.Abstract;
using Mappers.Abstaract;
using Models;
using Models.Abstract;
using Types;
using System;

namespace Mappers
{
    public class PowerSupplyMapper : IBaseMapper
    {
        public IBaseEntity ToEntity(BaseModel powerSupply) 
        {
            PowerSupplyModel powerSupplyModel = (PowerSupplyModel)powerSupply;
            return new PowerSupplyEntity
            {
                Id = powerSupplyModel.Id,
                Name = powerSupplyModel.Name,
                Wattage = powerSupplyModel.Wattage,
                PowerSupplyType = powerSupplyModel.PowerSupplyType.ToString(),

                DetailType = powerSupplyModel.DetailType
            };
        }
        public BaseModel ToModel(IBaseEntity powerSupply)
        {
            PowerSupplyEntity powerSupplyEntity = (PowerSupplyEntity)powerSupply;
            return new PowerSupplyModel
            {
                Id = powerSupplyEntity.Id,
                Name = powerSupplyEntity.Name,
                Wattage = powerSupplyEntity.Wattage,
                PowerSupplyType = (PowerSupplyType)Enum.Parse(typeof(PowerSupplyType), powerSupplyEntity.PowerSupplyType),

                DetailType = powerSupplyEntity.DetailType
            };
        }
    }
}
