using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse.Common.Managers;
using Warehouse.WindowsApp.UnityConfig;

namespace Warehouse.WindowsApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DependencyInjector.LoadConfiguration();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login(DependencyInjector.Retrieve<IWebApiClientManager>()));
        }
    }
}
