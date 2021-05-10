using Models.Abstract;
using Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ProcessorModel : BaseModel
    {
        public double Wattage { get; set; }
        public SocketType SocketType { get; set; }

        public override string ToString()
        {
            return $"Id: {Id} | " +
                                   $"Name: {Name} | " +
                                   $"Price: {Price} " +
                                   $"| Wattage: {Wattage} | " +
                                   $"Socket type: {SocketType}";
        }

    }
}
