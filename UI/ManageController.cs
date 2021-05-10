using Entity;
using Mappers;
using Mappers.Factories;
using Models;
using Models.Abstract;
using System.Collections.Generic;
using System.Linq;
using Types;
using UI.Abstract;

namespace UI
{
    public class ManageController : IController
    {
        private InMemoryDB Data { get; } = InMemoryDB.Instance;
        public IView View { get; set; }

        #region Init old mappers
        private CaseMapper CaseMapper = new CaseMapper();
        private MemoryCardMapper MemoryCardMapper = new MemoryCardMapper();
        private MotherboardMapper MotherboardMapper = new MotherboardMapper();
        private PowerSupplyMapper PowerSupplyMapper = new PowerSupplyMapper();
        private ProcessorMapper ProcessorMapper = new ProcessorMapper();
        #endregion
        private MapperFactory mapperFactory = new MapperFactory();
        
        public ManageController(IView view)
        {
            View = view;
            view.Controller = this;
        }
        #region OldMethods
        public List<CaseModel> GetAllCases()
        {
            return Data.CaseData.Select(caseEntity => (CaseModel)CaseMapper.ToModel(caseEntity)).ToList();
        }
        public List<MemoryCardModel> GetAllMemoryCards()
        {
            return (Data.MemoryCardData.Select(memoryCard => (MemoryCardModel)MemoryCardMapper.ToModel(memoryCard)).ToList());
        }
        public List<MotherboardModel> GetAllMotherboards()
        {
            return (Data.MotherboardData.Select(motherboard => (MotherboardModel)MotherboardMapper.ToModel(motherboard)).ToList());
        }
        public List<PowerSupplyModel> GetAllPowerSupplies()
        {
            return (Data.PowerSupplyData.Select(powerSupply => (PowerSupplyModel)PowerSupplyMapper.ToModel(powerSupply)).ToList());
        }
        public List<ProcessorModel> GetAllProcessors()
        {
            return (Data.ProssesorData.Select(processor => (ProcessorModel)ProcessorMapper.ToModel(processor)).ToList());
        }
        #endregion

        public BaseModel GetById(int id)
        {
            return GetAllDetail().Find(detail => detail.Id == id);
        }
        public List<BaseModel> GetAllDetail()
        {
            return Data.DetailsData.Select(detail => mapperFactory.SelectMapper(detail.DetailType).ToModel(detail)).ToList();
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
