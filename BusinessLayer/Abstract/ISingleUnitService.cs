using Models;
using Models.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using Types;

namespace BusinessLayer.Abstract
{
    public interface ISingleUnitService
    {
        void AddDetail(Detail detail);
        bool IsWorking();
        double Price { get; }

        IList<Detail> GetDetailByType(DetailType type);

        IList<IWattageConsumer> GetWattageConsumers();
    }
}
