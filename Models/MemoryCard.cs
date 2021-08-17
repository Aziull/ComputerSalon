
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
            return $"Id: {Id} | " +
                                  $"Name: {Name} | " +
                                  $"Price: {Price} | " +
                                  $"Memory card type: {MemoryCardType} | " +
                                  $"Wattage: {Wattage}";
        }
    }
}
