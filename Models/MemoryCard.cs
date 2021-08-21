
using Models.Abstract;
using Types;



namespace Models
{
    public class MemoryCard : Detail, IWattageConsumer
    {
        public double Wattage { get; set; }
        public string MemoryCardType { get; set; }

        public override string ToString()
        {
            return string.Format("Name: {0} | " + "Price: {1} | " + "Memory card type: {2} |  Wattage: {3}",Name,Price,MemoryCardType,Wattage);
        }
    }
}
