using Entity;
using Entity.Abstract;
using Mappers.Abstaract;
using Models;
using Models.Abstract;
using Types;
using System;

namespace Mappers
{
    public class MemoryCardMapper : IBaseMapper
    {
        public IBaseEntity ToEntity(BaseModel memoryCard)
        {
            MemoryCardModel memoryCardModel = (MemoryCardModel)memoryCard;
            return new MemoryCardEntity
            {
                Id = memoryCardModel.Id,
                Name = memoryCardModel.Name,
                Wattage = memoryCardModel.Wattage,
                MemoryCardType = memoryCardModel.MemoryCardType.ToString(),

                DetailType = memoryCardModel.DetailType
            };
        }
        public BaseModel ToModel(IBaseEntity memoryCard)
        {
            MemoryCardEntity memoryCardEntity = (MemoryCardEntity)memoryCard;
            return new MemoryCardModel
            {
                Id = memoryCardEntity.Id,
                Name = memoryCardEntity.Name,
                Wattage = memoryCardEntity.Wattage,
                MemoryCardType = (MemoryCardType)Enum.Parse(typeof(MemoryCardType), memoryCardEntity.MemoryCardType),

                DetailType = memoryCardEntity.DetailType
            };
        }
    }
}
