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
            Details[DetailType.Case] = new ObservableCollection<Detail>();
            Details[DetailType.MemoryCard] = new ObservableCollection<Detail>();
            Details[DetailType.Motherboard] = new ObservableCollection<Detail>();
            Details[DetailType.PowerSupply] = new ObservableCollection<Detail>();
            Details[DetailType.Processor] = new ObservableCollection<Detail>();
            FillData();
        }

        private async void FillData()
        {
            AddItems(DetailType.Case, await computerService.GetCasesAsync());
            AddItems(DetailType.MemoryCard, await computerService.GetMemoryCardsAsync());
            AddItems(DetailType.Motherboard, await computerService.GetMotherboardsAsync());
            AddItems(DetailType.PowerSupply, await computerService.GetPowerSuppliesAsync());
            AddItems(DetailType.Processor, await computerService.GetProcessorsAsync());

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
