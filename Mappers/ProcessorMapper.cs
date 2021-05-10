using Entity;
using Entity.Abstract;
using Mappers.Abstaract;
using Models;
using Models.Abstract;
using Types;
using System;

namespace Mappers
{
     public class ProcessorMapper : IBaseMapper
    {
        public IBaseEntity ToEntity(BaseModel powerSupply)
        {
            ProcessorModel processorModel = (ProcessorModel)powerSupply;
            return new ProcessorEntity
            {
                Id = processorModel.Id,
                Name = processorModel.Name,
                Wattage = processorModel.Wattage,
                SocketType = processorModel.SocketType.ToString(),

                DetailType = processorModel.DetailType
            };
        }

        public BaseModel ToModel(IBaseEntity processor)
        {
            ProcessorEntity processorEntity = (ProcessorEntity)processor;
            return new ProcessorModel
            {
                Id = processorEntity.Id,
                Name = processorEntity.Name,
                Wattage = processorEntity.Wattage,
                SocketType = (SocketType) Enum.Parse(typeof(SocketType), processorEntity.SocketType),

                DetailType = processorEntity.DetailType
            };
        }
    }
}
