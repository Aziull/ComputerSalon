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
        IList<Case> GetCases();
        IList<Processor> GetProcessors();
        IList<PowerSupply> GetPowerSupplies();
        IList<MemoryCard> GetMemoryCards();
        IList<Motherboard> GetMotherboards();
        
    }
}
