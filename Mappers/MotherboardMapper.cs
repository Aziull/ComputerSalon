using Entity;
using Entity.Abstract;
using Mappers.Abstaract;
using Models;
using Models.Abstract;
using Types;
using System;

namespace Mappers
{
    public class MotherboardMapper : IBaseMapper
    {
        public IBaseEntity ToEntity(BaseModel motherboard)
        {
            MotherboardModel motherboardModel = (MotherboardModel)motherboard;
            return new MotherboardEntity
            {
                Id = motherboardModel.Id,
                Name = motherboardModel.Name,
                MotherboardType = motherboardModel.MotherboardType.ToString(),
                MemoryCardTypeCompatibility = motherboardModel.MemoryCardTypeCompatibility.ToString(),
                SocketTypeCompatibility = motherboardModel.SocketTypeCompatibility.ToString(),

                DetailType = motherboardModel.DetailType
            };
        }

        public BaseModel ToModel(IBaseEntity motherboard)
        {
            MotherboardEntity motherboardEntity = (MotherboardEntity)motherboard;
            return new MotherboardModel
            {
                Id = motherboardEntity.Id,
                Price = motherboardEntity.Price,
                Name = motherboardEntity.Name,
                MotherboardType = (MotherboardType)Enum.Parse(typeof(MotherboardType), motherboardEntity.MotherboardType),
                MemoryCardTypeCompatibility = (MemoryCardType)Enum.Parse(typeof(MemoryCardType), motherboardEntity.MemoryCardTypeCompatibility),
                SocketTypeCompatibility = (SocketType)Enum.Parse(typeof(SocketType), motherboardEntity.SocketTypeCompatibility),

                DetailType = motherboardEntity.DetailType
            };
        }
    }
}
