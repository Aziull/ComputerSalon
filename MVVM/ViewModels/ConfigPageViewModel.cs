using BusinessLayer.Abstract;
using MathCore.ViewModels;
using Models;
using MVVM.Commands;
using MVVM.Models;
using MVVM.ViewModels.Base;
using System.Windows.Input;

namespace MVVM.ViewModels
{
    public class ConfigPageViewModel : ViewModelBase
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

        public ConfigPageViewModel(UnitMvvmDetails unitMvvmDetails, ISingleUnitService systemUnitHandler, ISystemUnitService systemUnitServcie) : base("Config")
        {
            
            Details = unitMvvmDetails;
            SystemUnit = new SystemUnit();
            createCommand = new CreateCommand(systemUnitHandler, Details, SystemUnit, systemUnitServcie);
        }
    }
}
