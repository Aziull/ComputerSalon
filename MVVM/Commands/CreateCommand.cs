using BusinessLayer.Abstract;
using Models;
using MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace MVVM.Commands
{
    public class CreateCommand : ICommand
    {
        private ISystemUnitHandler systemUnitHandler;
        private UnitMvvmDetails details;
        private SystemUnit systemUnit;
        private ISystemUnitService systemUnitService;

        
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public CreateCommand(ISystemUnitHandler systemUnitHandler, UnitMvvmDetails details, SystemUnit systemUnit, ISystemUnitService systemUnitService)
        {
            this.systemUnitHandler = systemUnitHandler;
            this.details = details;
            this.systemUnit = systemUnit;
            this.systemUnitService = systemUnitService;
        }
        
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            IList<Detail> sellectedDetails = details.Details.Values
                .SelectMany(item => item.ToList())
                .Where(item => item.IsSellected)
                .ToList();

            foreach (var detail in sellectedDetails)
            {
                systemUnitHandler.AddDetail(detail);
            }

            if (systemUnitHandler.IsWorking() && systemUnit.Name != null)
            {
                foreach (var detail in sellectedDetails)
                {
                    systemUnit.Details.Add(detail);

                }
                systemUnitService.Save(systemUnit);
                MessageBox.Show("could create system Unit");
            }
            else
            {
                MessageBox.Show("could not create system Unit");
            }
            

        }
    }
}
