using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

using Inventory.Models;
using Inventory.Presenters;
using Inventory._Repositories;
using Inventory.Views;

using System.Data;
using System.Data.SqlClient;
using System.IO;




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

            // String databaseName = "InventoryDb.mdf";
            // String path = Path.GetFullPath(Environment.CurrentDirectory);
            // SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + @"\Data\" + databaseName + ";Integrated Security=True");
            //string SqlConnectionString = Con.ConnectionString;

             ILoginView view = new LoginFrom();
             new LoginPresentor(view, sqlConnectionString);

        Application.Run((Form)view);
        }
    }
}
