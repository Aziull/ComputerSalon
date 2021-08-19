using MathCore.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using MVVM.Commands;
using MVVM.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace MVVM.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        //private ICommand changePageCommand;
        private ViewModelBase currentViewModel;
        private List<ViewModelBase> pageViewModels;

        public List<ViewModelBase> PageViewModels => pageViewModels
            ??= new List<ViewModelBase>();
        

        public ViewModelBase CurrentViewModel
        {
            get
            {
                return currentViewModel;
            }
            set
            {
                if (currentViewModel != value)
                {
                    currentViewModel = value;
                    OnPropertyChanged(nameof(CurrentViewModel));
                }
            }

        }

        private RelayCommand changePageCommand;
        public RelayCommand ChangePageCommand
        {
            get
            {
                return changePageCommand ??
                  (changePageCommand = new RelayCommand(pageTitle =>
                  {
                      if (currentViewModel.Title == (string)pageTitle)
                          return;
                      CurrentViewModel = null;
                      CurrentViewModel = PageViewModels.Find(viewModel => viewModel.Title == (string)pageTitle);
                  }));
            }
        }


        public MainWindowViewModel() : base("MainWindow")
        {
            PageViewModels.Add(App.Services.GetService<ConfigViewModel>());
            PageViewModels.Add(App.Services.GetService<ExistingUnitsViewModel>());

           CurrentViewModel = PageViewModels[0];
        }

       protected void ChangeViewModel(ViewModelBase viewModel)
        {
            currentViewModel = viewModel;
        }


    }
}
