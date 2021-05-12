

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

        public BaseModel GetById(int id)
        {
            return GetAllDetail().Find(detail => detail.Id == id);
        }
        public List<BaseModel> GetAllDetail()
        {
            return Data.DetailsData;
        }
        public List<BaseModel> GetDetailByType(DetailType type)
        {
            return GetAllDetail().FindAll(detail => detail.DetailType == type).ToList();
        }

        public bool IsPossibleToCreate(CaseModel Case, ProcessorModel Processor, MotherboardModel Motherboard, MemoryCardModel MemoryCard, PowerSupplyModel PowerSupply)
        {
            double SystemWatage = PowerSupply.CalculateSystemWattage(Processor.Wattage, MemoryCard.Wattage);
            bool IsCompatiblePowerSupply = PowerSupply.Wattage > SystemWatage;

            bool IsCompatibleWithMB = Motherboard.CheckMemoryCardCompatibility(MemoryCard.MemoryCardType)
                                      && Motherboard.CheckProcessorCompatibility(Processor.SocketType);

            bool IsCompatibleWithCase = Case.CheckMotherBoardСompatibility(Motherboard.MotherboardType) 
                                        && Case.CheckPowerSupplyСompatibility(PowerSupply.PowerSupplyType);



            return IsCompatibleWithMB && IsCompatibleWithCase && IsCompatiblePowerSupply;
        }
    }
}
