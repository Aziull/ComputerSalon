

using Models;
using Models.Abstract;
using System.Collections.Generic;
using System.Linq;
using Types;


namespace UI
{
    public class ManageController
    {
        private InMemoryDB Data { get; } = InMemoryDB.Instance;
        public ConsoleView View { get; set; }

        
        
        public ManageController(ConsoleView view)
        {
            View = view;
            view.Controller = this;
        }

        public Detail GetById(int id)
        {
            return GetAllDetail().Find(detail => detail.Id == id);
        }
        public List<Detail> GetAllDetail()
        {
            return Data.DetailsData;
        }
        public List<Detail> GetDetailByType(DetailType type)
        {
            return GetAllDetail().FindAll(detail => detail.Type == type).ToList();
        }

        public bool IsPossibleToCreate(IList<Detail> details)
        {
            var consumers = GetWattageConsumers(details);

            PowerSupply powerSupply = details
                .Where(detail => detail.Type == DetailType.PowerSupply)
                                .Select(detail => detail as PowerSupply)
                                .FirstOrDefault();

            Motherboard motherboard = details
                .Where(detail => detail.Type == DetailType.Motherboard)
                .Select(detail => detail as Motherboard)
                .FirstOrDefault();

            MemoryCard memoryCard = details
                .Where(detail => detail.Type == DetailType.MemoryCard)
                .Select(detail => detail as MemoryCard)
                .FirstOrDefault();

            Processor processor = details
                .Where(detail => detail.Type == DetailType.Processor)
                .Select(detail => detail as Processor)
                .FirstOrDefault();

            Case unitCase = details
                .Where(detail => detail.Type == DetailType.Case)
                .Select(detail => detail as Case)
                .FirstOrDefault();

            

            bool isCompatibleMb = motherboard.CheckMemoryCardCompatibility(memoryCard) &&
                motherboard.CheckProcessorCompatibility(processor);

            bool IsCompatibleWithCase = unitCase.CheckMotherBoardСompatibility(motherboard) 
                                        && unitCase.CheckPowerSupplyСompatibility(powerSupply);

            bool IsCompatiblePowerSupply = powerSupply.IsEnoughPower(consumers);

            return IsCompatiblePowerSupply && isCompatibleMb && IsCompatibleWithCase;
        }
        private IList<IWattageConsumer> GetWattageConsumers(IList<Detail> details)
        {
            IList<IWattageConsumer> consumers = new List<IWattageConsumer>();

            foreach (var detail in details)
            {

                    if (detail is IWattageConsumer)
                    {
                        consumers.Add((IWattageConsumer)detail);
                    }
                
            }
            return consumers;
        }
    }
}
