using MathCore.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;

namespace MVVM.ViewModels.Base
{
    public class ViewModelBase : ViewModel
    {
        public string title;
        public string Title { get => title; set => Set(ref title, value); }
        public ViewModelBase(string title)
        {
            this.title = title;
        }

    }
}
