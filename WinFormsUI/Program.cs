using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsUI.Presenters;
using WinFormsUI.Views;

namespace WinFormsUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var presenter = new MainPresenter(new MainView(), InMemoryDB.Instance);
            presenter.Run();
        }
    }
}
