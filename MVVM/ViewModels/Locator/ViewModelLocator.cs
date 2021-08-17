using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVVM.ViewModels.Locator
{
     class ViewModelLocator
    {
        public MainViewModel MainVM => App.Services.GetRequiredService<MainViewModel>();
    }
}
