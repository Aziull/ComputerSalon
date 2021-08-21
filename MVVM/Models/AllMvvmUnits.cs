using BusinessLayer.Abstract;
using Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace MVVM.Models
{
    public class AllMvvmUnits : INotifyPropertyChanged
    {
        private ISystemUnitService systemUnitService;
        private ObservableCollection<SystemUnit> systemUnits;
        public ObservableCollection<SystemUnit> SystemUnits
        {
            get => systemUnits;
            set
            {
                systemUnits = value;
                OnPropertyChanged(nameof(SystemUnits));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public AllMvvmUnits(ISystemUnitService systemUnitService)
        {
            this.systemUnitService = systemUnitService;
            SystemUnits = new ObservableCollection<SystemUnit>();
            FillData();
        }

        private  void FillData()
        {
            AddItems(systemUnitService.GetSystemUnits());
        }
        private void AddItems(IList<SystemUnit> systemUnits)
        {
            foreach(var item in systemUnits)
            {
                this.SystemUnits.Add(item);
            }
        }
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
