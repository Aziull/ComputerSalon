using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace Entity.Abstract
{
    public interface IBaseEntity
    {
        int Id { get; set; }
        string Name { get; set; }
        int Price { get; set; }
        DetailType DetailType { get; set; }

    }
}
