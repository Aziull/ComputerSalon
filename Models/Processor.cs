using Models.Abstract;
using Types;

namespace Models
{
    public class Processor : Detail, IWattageConsumer
    {
        public double Wattage { get; set; }

        public string SocketType { get; set; }
        public override string ToString()
        {
            return $"Id: {Id} | " +
                                   $"Name: {Name} | " +
                                   $"Price: {Price} " +
                                   $"| Wattage: {Wattage} | ";
        }

    }
}
