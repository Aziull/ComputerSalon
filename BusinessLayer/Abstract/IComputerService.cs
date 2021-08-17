using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace BusinessLayer.Abstract
{
    public interface IComputerService
    {
        Task<IList<Case>> GetCasesAsync();
        Task<IList<Processor>> GetProcessorsAsync();
        Task<IList<PowerSupply>> GetPowerSuppliesAsync();
        Task<IList<MemoryCard>> GetMemoryCardsAsync();
        Task<IList<Motherboard>> GetMotherboardsAsync();
        
    }
}
