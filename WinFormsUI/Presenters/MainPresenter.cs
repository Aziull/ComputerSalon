
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsUI.Presenters.Abstract;
using WinFormsUI.Views.Abstract;

namespace WinFormsUI.Presenters
{
    class MainPresenter : IMainPresenter
    {
        private readonly IView _view;

        private InMemoryDB Data;

        public MainPresenter(IView view, InMemoryDB data)
        {
            _view = view;
            Data = data;
            SubscribeOnViewEvent();
        }
        public void SubscribeOnViewEvent()
        {

        }

        public void Run()
        {
            _view.Show();
        }

    }
}
