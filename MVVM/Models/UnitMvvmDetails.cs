using BusinessLayer.Abstract;
using Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Types;

namespace MVVM.Models
{
    public class UnitMvvmDetails : INotifyPropertyChanged
    {
        private IComputerService computerService;

        public IDictionary<DetailType, ObservableCollection<Detail>> Details { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        public UnitMvvmDetails(IComputerService computerService)
        {
            this.computerService = computerService;
            Details = new Dictionary<DetailType, ObservableCollection<Detail>>();
            Details[DetailType.Case] = new ObservableCollection<Detail>();
            Details[DetailType.MemoryCard] = new ObservableCollection<Detail>();
            Details[DetailType.Motherboard] = new ObservableCollection<Detail>();
            Details[DetailType.PowerSupply] = new ObservableCollection<Detail>();
            Details[DetailType.Processor] = new ObservableCollection<Detail>();
            FillData();
        }

        private void FillData()
        {
            AddItems(DetailType.Case, computerService.GetCases());
            AddItems(DetailType.MemoryCard, computerService.GetMemoryCards());
            AddItems(DetailType.Motherboard, computerService.GetMotherboards());
            AddItems(DetailType.PowerSupply, computerService.GetPowerSupplies());
            AddItems(DetailType.Processor, computerService.GetProcessors());

        }

        private void AddItems<T>(DetailType type, IList<T> details) where T: Detail
        {
            foreach(var detail in details)
            {
                Details[type].Add(detail);  
            }
        }
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
