using BusinessLayer.Abstract;
using MathCore.ViewModels;
using Models;
using MVVM.Commands;
using MVVM.Models;
using System.Windows.Input;

namespace MVVM.ViewModels
{
    public class ConfigViewModel : ViewModel
    {
        private ICommand createCommand;
        private SystemUnit systemUnit;

        public UnitMvvmDetails Details { get; set; }
        public ICommand CreateCommand
        {
            get => createCommand;
        }


        public SystemUnit SystemUnit
        {
            get => systemUnit;
            set
            {
                systemUnit = value;
                OnPropertyChanged(nameof(SystemUnit));
            }
        }

        public ConfigViewModel(UnitMvvmDetails unitMvvmDetails, ISystemUnitHandler systemUnitHandler, ISystemUnitService systemUnitServcie) 
        {
            Details = unitMvvmDetails;
            SystemUnit = new SystemUnit();
            createCommand = new CreateCommand(systemUnitHandler, Details, SystemUnit, systemUnitServcie);
        }
    }
}
