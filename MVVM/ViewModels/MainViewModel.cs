using MathCore.ViewModels;
using System.Windows.Input;

namespace MVVM.ViewModels
{
    public class MainViewModel : ViewModel
    {
        private ICommand showConfigViewCommand;
        private string title;
        private ViewModel currentViewModel;
        private ConfigViewModel configViewModel;
        private ExistingUnitsViewModel existingUnitsViewModel;

        public ConfigViewModel ConfigViewModel
        {
            get => configViewModel;
        }
        public ExistingUnitsViewModel ExistingUnitsViewModel
        {
            get => existingUnitsViewModel;
        }

        public string Title { get => title; set => Set(ref title, value); }

       // public ICommand ShowConfigViewCommand => showConfigViewCommand
         //   ??= new LambdaComand(true, OnShowConfigViewCommandExecuted);
        public ViewModel CurrentViewModel  { get => currentViewModel; set => Set(ref currentViewModel, value); }

        public MainViewModel()
        {
            //configViewModel = App.Services.GetService<ConfigViewModel>();
        }
        private bool CanShowConfigViewCommandExecute(object p) => true;
        private void OnShowConfigViewCommandExecuted(object p)
        {
          //  currentViewModel );
        }

    }
}
