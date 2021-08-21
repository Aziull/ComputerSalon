using BusinessLayer.Abstract;
using Models;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using MVVM.ViewModels.Base;


namespace MVVM.ViewModels
{
    public class ExistingUnitsPageViewModel : ViewModelBase
    {
        ISystemUnitService systemUnitService;
        private SystemUnit selectedPC;

        public ObservableCollection<SystemUnit> SystemUnits;

        public SystemUnit SelectedPC
        {
            get => selectedPC;
            set
            {
                selectedPC = value;
                OnPropertyChanged(nameof(SelectedPC));
            }
        }

        public ExistingUnitsPageViewModel(ISystemUnitService systemUnitService) : base("Existing PCs")
        {
            this.systemUnitService = systemUnitService;
            SelectedPC = new SystemUnit();
            FillData();
        }
        private void FillData()
        {
            AddItems(systemUnitService.GetSystemUnits());
        }
        private void AddItems(IList<SystemUnit> systemUnits)
        {
            foreach (var systemUnit in systemUnits)
            {
               

            }
        }

    }
}
