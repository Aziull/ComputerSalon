using Entity;
using Entity.Abstract;
using Mappers.Abstaract;
using Models;
using Models.Abstract;
using Types;
using System;

namespace Mappers
{
    public class CaseMapper : IBaseMapper
    {     
        public IBaseEntity ToEntity(BaseModel Case)
        {
            CaseModel CaseModel = (CaseModel)Case;
            return new CaseEntity
            {
                Id = Case.Id,
                Name = Case.Name,
                MotherboardTypeСompatibility = CaseModel.MotherboardTypeСompatibility.ToString(),
                PowerSupplyTypeCompatybility = CaseModel.PowerSupplyTypeCompatybility.ToString(),

                DetailType = CaseModel.DetailType
            };
        }
        public BaseModel ToModel(IBaseEntity Case)
        {
            CaseEntity CaseEntity = (CaseEntity)Case;
            return new CaseModel
            {
                Id = Case.Id,
                Name = Case.Name,
                MotherboardTypeСompatibility = (MotherboardType) Enum.Parse(typeof(MotherboardType), CaseEntity.MotherboardTypeСompatibility),
                PowerSupplyTypeCompatybility = (PowerSupplyType) Enum.Parse(typeof(PowerSupplyType), CaseEntity.PowerSupplyTypeCompatybility),

                DetailType = CaseEntity.DetailType
            };
        }
    }
}
