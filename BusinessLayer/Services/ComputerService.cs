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

        public async Task<IList<Case>> GetCasesAsync()
        {
            return await GetDetailByTypeAsync(DetailType.Case, new CaseMapper());
        }

       

        public async Task<IList<MemoryCard>> GetMemoryCardsAsync()
        {
            return await GetDetailByTypeAsync(DetailType.MemoryCard, new MemmoryCardMapper());
        }

        public async Task<IList<Motherboard>> GetMotherboardsAsync()
        {
            return await GetDetailByTypeAsync(DetailType.Motherboard, new MotherboardMapper());
        }

        public async Task<IList<PowerSupply>> GetPowerSuppliesAsync()
        {
            return await GetDetailByTypeAsync(DetailType.PowerSupply, new PowerSupplyMapper());

        }

        public async Task<IList<Processor>> GetProcessorsAsync()
        {
            return await GetDetailByTypeAsync(DetailType.Processor, new ProcessorMapper());

        }
        public async Task<IList<T>> GetDetailByTypeAsync<T>(DetailType detailType, IModelMapper<T> mapper) where T: Detail
        {
            return (await unitOfWork.DetailRepository.GetDetailsByType((int)detailType)).Select(mapper.ToModel).ToList();
        }
    }
}
