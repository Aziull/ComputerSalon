using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI;
using UI.Abstract;

namespace ComputerSalon
{
    class Program
    {
        static void Main(string[] args)
        {
            IView consoleView = new ConsoleView();
            IController manageController = new ManageController(consoleView);
            manageController.View.Start();
        }
    }
}
