using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory.Views;

namespace Inventory
{
    public partial class DashboardForm : Form, IMainView
    {
        //Constractor
        public DashboardForm()
        {
            InitializeComponent();
            addItemBtn.Click += delegate 
            {
                ShowItemView?.Invoke(this, EventArgs.Empty);
                ChangeActiveButtonColor?.Invoke(addItemBtn, EventArgs.Empty);
            };
            transferItemBtn.Click += delegate 
            { 
                ShowTransmissionView?.Invoke(this, EventArgs.Empty); 
                ChangeActiveButtonColor?.Invoke(transferItemBtn, EventArgs.Empty);
            };
            inventoryBtn.Click += delegate 
            {
                ShowInventoryView?.Invoke(this, EventArgs.Empty); 
                ChangeActiveButtonColor?.Invoke(inventoryBtn, EventArgs.Empty);
            };
            usersBtn.Click += delegate 
            {
                ShowUsersView?.Invoke(this, EventArgs.Empty); 
                ChangeActiveButtonColor?.Invoke(usersBtn, EventArgs.Empty);
            };
            settingsBtn.Click += delegate 
            { 
                ShowSettingsView?.Invoke(this, EventArgs.Empty); 
                ChangeActiveButtonColor?.Invoke(settingsBtn, EventArgs.Empty);
            };
        }
        //Event To show New View
        public event EventHandler ShowItemView;
        public event EventHandler ShowTransmissionView;
        public event EventHandler ShowInventoryView;
        public event EventHandler ShowUsersView;
        public event EventHandler ShowSettingsView;
        //Event To Change the Button color as presserd
        public event EventHandler ChangeActiveButtonColor;
        private void DashboardFrom_Load(object sender, EventArgs e)
        {
            inventoryBtn.Enabled = false;
            settingsBtn.Enabled = false;
            button1.Enabled = false;
            usersBtn.Enabled = false;
        }
    }
}
