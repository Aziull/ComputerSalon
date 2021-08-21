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
            return string.Format( "Name: {0} | Price: {1} | Wattage: {2} | Socket Type: {3}", Name, Price, Wattage, SocketType);
        }

    }
}
