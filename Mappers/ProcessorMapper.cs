using Mappers.Abstract;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mappers
{
    public class ProcessorMapper : IModelMapper<Processor>
    {
        public Processor ToModel(Entities.Detail detail)
        {
            Processor processor = new Processor()
            {
                Id = detail.Id,
                Name = detail.Name,
                Price = detail.Price,
                Type = (Types.DetailType)detail.TypeId
            };
            processor.Wattage = Int32.Parse(detail.Values.
               Where(value => value.Property.Name == "wattage").
               Select(value => value.Data).
               FirstOrDefault());

            processor.SocketType = detail.Values.Where(value => value.Property.Name == "SocketFactor").Select(value => value.Data).FirstOrDefault();


            return processor;
        }
    }
}
