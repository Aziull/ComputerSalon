using Entity.Abstract;
using Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mappers.Abstaract
{
    public interface IBaseMapper   
    {
        IBaseEntity ToEntity(BaseModel U);
        BaseModel ToModel(IBaseEntity T);
    }
}
