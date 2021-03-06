using System;
using System.ComponentModel;
using System.Windows;

namespace MVVM.ViewModels.Locator
{
     public static class ViewModelLocator
    {
        public static readonly DependencyProperty AutoHookedUpViewModelProperty =
          DependencyProperty.RegisterAttached("AutoHookedUpViewModel",
          typeof(bool), typeof(ViewModelLocator), new
          PropertyMetadata(false, AutoHookedUpViewModelChanged));

        public static bool GetAutoHookedUpViewModel(DependencyObject obj)
        {
            return (bool)obj.GetValue(AutoHookedUpViewModelProperty);
        }

        public static void SetAutoHookedUpViewModel(DependencyObject obj, bool value)
        {
            obj.SetValue(AutoHookedUpViewModelProperty, value);
        }

<<<<<<< HEAD
=======
        
        public static readonly DependencyProperty AutoHookedUpViewModelProperty =
           DependencyProperty.RegisterAttached("AutoHookedUpViewModel",
           typeof(bool), typeof(ViewModelLocator), new
           PropertyMetadata(false, AutoHookedUpViewModelChanged));
>>>>>>> 10d40b4b136dc3c17be91d02f86eb229fc7e2f74

        private static void AutoHookedUpViewModelChanged(DependencyObject d,
           DependencyPropertyChangedEventArgs e)
        {
            if (DesignerProperties.GetIsInDesignMode(d)) return;
            var viewType = d.GetType();

            string str = viewType.FullName;
            str = str.Replace(".Pages.", ".ViewModels.");

            var viewTypeName = str;
            var viewModelTypeName = viewTypeName + "ViewModel";
            var viewModelType = Type.GetType(viewModelTypeName);
            var viewModel = Activator.CreateInstance(viewModelType);

            ((FrameworkElement)d).DataContext = viewModel;
        }
    }
}
