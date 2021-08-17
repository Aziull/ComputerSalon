

using Models;
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

        public bool IsPossibleToCreate(Case Case, Processor Processor, Motherboard Motherboard, MemoryCard MemoryCard, PowerSupply PowerSupply)
        {
            /*double SystemWatage = PowerSupply.CalculateSystemWattage(Processor.Wattage, MemoryCard.Wattage);
            bool IsCompatiblePowerSupply = PowerSupply.Power > SystemWatage;

            bool IsCompatibleWithMB = Motherboard.CheckMemoryCardCompatibility(MemoryCard.MemoryCardType)
                                      && Motherboard.CheckProcessorCompatibility(Processor.SocketType);

            bool IsCompatibleWithCase = Case.CheckMotherBoardСompatibility(Motherboard.MotherboardType) 
                                        && Case.CheckPowerSupplyСompatibility(PowerSupply.PowerSupplyType);*/



            return false;
        }
    }
}
