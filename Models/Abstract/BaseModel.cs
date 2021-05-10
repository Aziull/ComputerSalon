using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace Models.Abstract
{
    public class BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public DetailType DetailType {get; set;}
    }
}
