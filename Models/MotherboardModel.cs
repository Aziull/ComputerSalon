using Models.Abstract;
using Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class MotherboardModel : BaseModel
    {
        public MotherboardType MotherboardType { get; set; }
        public SocketType SocketTypeCompatibility { get; set; }
        public MemoryCardType MemoryCardTypeCompatibility { get; set; }

        public bool CheckMemoryCardCompatibility(MemoryCardType type)
        {
           return MemoryCardTypeCompatibility == type; 
        }
        public bool CheckProcessorCompatibility(SocketType type)
        {
           return SocketTypeCompatibility == type; 
        }

        public override string ToString()
        {
            return $"Id: {Id} | " +
                                  $"Name: {Name} | " +
                                  $"Price: {Price} " +
                                  $"| Memory card type: {MotherboardType} | \n" +
                                  $"Memory card compatibility: {MemoryCardTypeCompatibility} | " +
                                  $"Socket compatibility: {SocketTypeCompatibility}";
        }
    }
}
