using Mappers.Abstract;
using Models;
using System;
using System.Linq;
using Types;

namespace Mappers
{
    public class CaseMapper : IModelMapper<Case>
    {
        public Case ToModel(Entities.Detail detail)
        {
            Case unitCase = new Case
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

            unitCase.MotherboardTypeСompatibility = detail.Values.Where(value => value.Property.Name == "MotherboardFactor").Select(value => value.Data).FirstOrDefault();
            unitCase.MaxPowerSupplySize = new Tuple<int, int, int>(width, height, depth);
            return unitCase;
        }
    }
}
