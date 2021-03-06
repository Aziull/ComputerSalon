using Models.Abstract;
using System;
using System.Collections.Generic;
using Types;

namespace Models
{
    public class PowerSupply : Detail
    {
        public Tuple<int,int,int> Size { get; set; }
        public double Power { get; set; }


        public bool IsEnoughPower(IList<IWattageConsumer> consumers)
        {
            double totalWattage = 0;
            foreach(var consumer in consumers)
            {
                totalWattage += consumer.Wattage;
            }
            return Power >= totalWattage;
        }

        public override string ToString()
        {
            return String.Format("Name: {0} | Price: {1} | Power: {2} | Size: {3}", Name, Price, Power, Size);
        }
    }
}
