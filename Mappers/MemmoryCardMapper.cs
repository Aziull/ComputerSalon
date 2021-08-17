using Mappers.Abstract;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mappers
{
    public class MemmoryCardMapper : IModelMapper<MemoryCard>
    {
        public MemoryCard ToModel(Entities.Detail detail)
        {
            MemoryCard memoryCard = new MemoryCard()
            {
                Id = detail.Id,
                Name = detail.Name,
                Price = detail.Price,
                Type = (Types.DetailType)detail.TypeId
            };
            memoryCard.Wattage = Int32.Parse(detail.Values.
               Where(value => value.Property.Name == "wattage").
               Select(value => value.Data).
               FirstOrDefault());

            memoryCard.MemoryCardType = detail.Values.
               Where(value => value.Property.Name == "MotherboardFactor").
               Select(value => value.Data).
               FirstOrDefault();

            memoryCard.MemoryCardType = detail.Values.Where(value => value.Property.Name == "MemoryCardFactor").Select(value => value.Data).FirstOrDefault();

            return memoryCard;
        }
    }
}
