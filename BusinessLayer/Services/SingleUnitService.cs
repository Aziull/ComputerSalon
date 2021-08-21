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
    public class SingleUnitService : ISingleUnitService
    {
        private PowerValidator powerValidator;
        private SizeValidator sizeValidator;
        private FormFactorValidator formFactorValidator;

        private IDictionary<DetailType, IList<Detail>> details;
        public double Price { get; set; }

        public SingleUnitService(PowerValidator powerValidator, SizeValidator sizeValidator, FormFactorValidator formFactorValidator)
        {
            this.powerValidator = powerValidator;
            this.sizeValidator = sizeValidator;
            this.formFactorValidator = formFactorValidator;
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
            formFactorValidator.Next = sizeValidator;
            sizeValidator.Next = powerValidator;//DI 

            return formFactorValidator.Validate(this);
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
