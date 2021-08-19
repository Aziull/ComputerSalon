using BusinessLayer.Abstract;
using MathCore.ViewModels;
using System.Windows.Input;
using Models;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using MVVM.ViewModels.Base;
using MVVM.Models;

namespace MVVM.ViewModels
{
    public class ExistingUnitsViewModel : ViewModelBase
    {
        private SystemUnit selectedPC;

        public AllMvvmUnits systemUnits;

        public SystemUnit SelectedPC
        {
            get => selectedPC;
            set
            {
                selectedPC = value;
                OnPropertyChanged(nameof(SelectedPC));
            }
        }

        public ExistingUnitsViewModel() : base("Existing PCs")
        {
            
            SelectedPC = new SystemUnit();
           
        }

        
    }
}
