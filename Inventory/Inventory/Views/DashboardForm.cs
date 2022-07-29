using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Inventory.Theme;
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

                titleLabel.Text = addItemBtn.Text;

            };
            transferItemBtn.Click += delegate 
            { 
                ShowTransmissionView?.Invoke(this, EventArgs.Empty); 
                ChangeActiveButtonColor?.Invoke(transferItemBtn, EventArgs.Empty);

                titleLabel.Text = transferItemBtn.Text;

            };
            inventoryBtn.Click += delegate 
            {
                ShowInventoryView?.Invoke(this, EventArgs.Empty); 
                ChangeActiveButtonColor?.Invoke(inventoryBtn, EventArgs.Empty);

                titleLabel.Text = inventoryBtn.Text;

            };
            usersBtn.Click += delegate 
            {
                ShowUsersView?.Invoke(this, EventArgs.Empty); 
                ChangeActiveButtonColor?.Invoke(usersBtn, EventArgs.Empty);

                titleLabel.Text = usersBtn.Text;

            };
            settingsBtn.Click += delegate 
            { 
                ShowSettingsView?.Invoke(this, EventArgs.Empty); 
                ChangeActiveButtonColor?.Invoke(settingsBtn, EventArgs.Empty);

                titleLabel.Text = settingsBtn.Text;

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

        private void btnSettings_Click(object sender, EventArgs e)
        {
        }
        private void DashboardFrom_Load(object sender, EventArgs e)
        {
        }
        private void addItemBtn_Click(object sender, EventArgs e)
        {

        }
        private void transferItemBtn_Click(object sender, EventArgs e)
        {

        }
        private void inventoryBtn_Click(object sender, EventArgs e)
        {

        }
        private void usersBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
