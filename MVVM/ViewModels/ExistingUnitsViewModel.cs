using BusinessLayer.Abstract;
using MathCore.ViewModels;
using System.Windows.Input;
using Models;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace MVVM.ViewModels
{
    public class ExistingUnitsViewModel : ViewModel
    {
        private ISystemUnitService systemUnitService;

        private SystemUnit selectedPC;
        private ObservableCollection<SystemUnit> systemUnits;



        public SystemUnit SelectedPC
        {
            get => selectedPC;
            set
            {
                selectedPC = value;
                OnPropertyChanged(nameof(SelectedPC));
            }
        }

        public ObservableCollection<SystemUnit> SystemUnits
        {
            get => systemUnits;
            set
            {
                systemUnits = value;
                OnPropertyChanged(nameof(SystemUnits));
            }
        }

        public ExistingUnitsViewModel(ISystemUnitService systemUnitService)
        {
            this.systemUnitService = systemUnitService;
            SelectedPC = new SystemUnit();
            GetSystemUnits();
        }

        private async void GetSystemUnits()
        {
            IList<SystemUnit> allSystemUnits = await systemUnitService.GetSystemUnitsAsync();
            SystemUnits = new ObservableCollection<SystemUnit>(allSystemUnits);
        }
    }
}
