using Models;
using Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace UI.Abstract
{
    public interface IController
    {
        IView View { get; set; }
        BaseModel GetById(int id);
        List<BaseModel> GetAllDetail();
        List<BaseModel> GetDetailByType(DetailType type);
        bool IsPossibleToCreate(CaseModel Case, ProcessorModel Processor, MotherboardModel Motherboard, MemoryCardModel MemoryCard, PowerSupplyModel PowerSupply);
    }
}
