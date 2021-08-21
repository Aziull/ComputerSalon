using BusinessLayer.Abstract;
using DataLayer.Abstract;
using Mappers;
using Mappers.Abstract;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace BusinessLayer.Services
{
    public class ComputerService : IComputerService
    {
        private readonly IUnitOfWork unitOfWork;

        public ComputerService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public  IList<Case> GetCases()
        {
            return  GetDetailByType(DetailType.Case, new CaseMapper());
        }

        public  IList<MemoryCard> GetMemoryCards()
        {
            return  GetDetailByType(DetailType.MemoryCard, new MemmoryCardMapper());
        }

        public  IList<Motherboard> GetMotherboards()
        {
            return  GetDetailByType(DetailType.Motherboard, new MotherboardMapper());
        }

        public  IList<PowerSupply> GetPowerSupplies()
        {
            return  GetDetailByType(DetailType.PowerSupply, new PowerSupplyMapper());

        }

        public  IList<Processor> GetProcessors()
        {
            return  GetDetailByType(DetailType.Processor, new ProcessorMapper());

        }
        private  IList<T> GetDetailByType<T>(DetailType detailType, IModelMapper<T> mapper) where T: Detail
        {
            return unitOfWork.DetailRepository.GetDetailsByType((int)detailType).Select(mapper.ToModel).ToList();
        }
    }
}
