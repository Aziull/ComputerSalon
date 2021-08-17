using Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Motherboard : Detail
    {
        public string MotherboardType { get; set; }
        public string SocketTypeCompatibility { get; set; }
        public string MemoryCardTypeCompatibility { get; set; }

        public bool CheckMemoryCardCompatibility(MemoryCard memoryCard)
        {
           return MemoryCardTypeCompatibility == memoryCard.MemoryCardType; 
        }
        public bool CheckProcessorCompatibility(Processor processor)
        {
           return SocketTypeCompatibility == processor.SocketType; 
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
