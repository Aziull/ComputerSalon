using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsUI.Views.Abstract
{
    public interface IMainView : IView
    {
        event EventHandler CheckConfig;
        
        
    }
}
