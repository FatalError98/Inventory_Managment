using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

using Inventory.Model;
using Inventory.Presenters;
using Inventory._Repositories;
using Inventory.Views;




namespace Inventory
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string sqlConnectionString = ConfigurationManager.ConnectionStrings["SqlConnectionString"].ConnectionString;
            IMainView view = new DashboardForm();
            new MainPresentor(view, sqlConnectionString);
            //
            Application.Run((Form)view);
        }
    }
}
