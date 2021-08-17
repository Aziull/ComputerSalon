using BusinessLayer.Abstract;
using BusinessLayer.Validators;
using Models;
using Models.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using Types;

namespace BusinessLayer.Handlers
{
    public class SystemUnitHandler : ISystemUnitHandler
    {
        private IDictionary<DetailType, IList<Detail>> details;
        public double Price { get; set; }

        public SystemUnitHandler()
        {
            details = new Dictionary<DetailType, IList<Detail>>();

            Init();

        }


        public IList<IWattageConsumer> GetWattageConsumers()
        {
            IList<IWattageConsumer> consumers = new List<IWattageConsumer>();

            foreach(var detail in details.Values)
            {
               foreach(var item in detail)
                {
                    if (item is IWattageConsumer)
                    {
                        consumers.Add((IWattageConsumer)item);
                    }
                }
            }
            return consumers;
        }

        public bool IsWorking()
        {
            var powerValidator = new PowerValidator();
            var sizeValidator = new SizeValidator();
            var formFactorValidator = new FormFactorValidator();

            return powerValidator.Validate(this) && sizeValidator.Validate(this) && formFactorValidator.Validate(this);
        }

        public IList<Detail> GetDetailByType(DetailType type)
        {
            return details[type];
        }
        private void Init()
        {

            Price = 0;
            foreach (DetailType componentType in Enum.GetValues(typeof(DetailType)))
            {
                details.Add(componentType, new List<Detail>());

            }
        }

        public void AddDetail(Detail detail)
        {
            Price += detail.Price;
            details[detail.Type].Add(detail);
        }
    }
}
