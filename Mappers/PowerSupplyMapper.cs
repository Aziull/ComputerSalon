using Mappers.Abstract;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mappers
{
    public class PowerSupplyMapper : IModelMapper<PowerSupply>
    {
        public PowerSupply ToModel(Entities.Detail detail)
        {
            PowerSupply powerSupply = new PowerSupply()
            {
                Id = detail.Id,
                Name = detail.Name,
                Price = detail.Price,
                Type = (Types.DetailType)detail.TypeId
            };

            int width = Int32.Parse(detail.Values.
                            Where(value => value.Property.Name == "width").
                            Select(value => value.Data).
                            FirstOrDefault());

            int height = Int32.Parse(detail.Values.
                Where(value => value.Property.Name == "height").
                Select(value => value.Data).
                FirstOrDefault());

            int depth = Int32.Parse(detail.Values.
                Where(value => value.Property.Name == "depth").
                Select(value => value.Data).
                FirstOrDefault());

            powerSupply.Size = new Tuple<int, int, int>(width, height, depth);

            powerSupply.Power = Int32.Parse(detail.Values.
                Where(value => value.Property.Name == "power").
                Select(value => value.Data).
                FirstOrDefault());

            return powerSupply; 
        }
    }
}
