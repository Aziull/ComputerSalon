using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Abstract
{
    public interface IView
    {
        IController Controller { get; set; }
        void Start();
    }
}
