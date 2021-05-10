using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI;


namespace ComputerSalon
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleView consoleView = new ConsoleView();
            ManageController manageController = new ManageController(consoleView);
            manageController.View.Start();
        }
    }
}
