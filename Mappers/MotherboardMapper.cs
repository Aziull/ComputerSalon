using Mappers.Abstract;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mappers
{
    public class MotherboardMapper : IModelMapper<Motherboard>
    {
        public Motherboard ToModel(Entities.Detail detail)
        {
            Motherboard motherboard = new Motherboard()
            {
                Id = detail.Id,
                Name = detail.Name,
                Price = detail.Price,
                Type = (Types.DetailType)detail.TypeId
            };

            motherboard.MotherboardType = detail.Values.Where(value => value.Property.Name == "MotherboardFactor").Select(value => value.Data).FirstOrDefault();
            motherboard.SocketTypeCompatibility = detail.Values.Where(value => value.Property.Name == "SocketFactor").Select(value => value.Data).FirstOrDefault();
            motherboard.MemoryCardTypeCompatibility = detail.Values.Where(value => value.Property.Name == "MemoryCardFactor").Select(value => value.Data).FirstOrDefault();

            return motherboard;
        }
    }
}
