using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory.Views
{
    public partial class LoginFrom : Form, ILoginView
    {
        public LoginFrom()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvent();
        }
        private bool isAdmin;
        private bool isSuccessful;
        private string message;

        public string UserName 
        {
            get => userNameTxt.Text; 
            set => userNameTxt.Text = value; 
        }
        public string Password 
        { 
            get => passwordTxt.Text; 
            set => passwordTxt.Text = value; 
        }
        public bool IsAdmin 
        { 
            get => isAdmin; 
            set => isAdmin = value; 
        }
        public bool IsSuccessful 
        { 
            get => isSuccessful; 
            set => isSuccessful = value; 
        }
        public string Message 
        {
            get => message; 
            set => message = value;
        }

        public event EventHandler LoginEvent;
        public event EventHandler CloseView;
        public event EventHandler MinimizedView;
        public event EventHandler MaximizedView;

        private void AssociateAndRaiseViewEvent()
        {
            exitBtn.Click += delegate
            {
                CloseView?.Invoke(this, EventArgs.Empty);
            };
            minimizedBtn.Click += delegate
            {
                MinimizedView?.Invoke(this, EventArgs.Empty);
            };
            maximizedBtn.Click += delegate
            {
                MaximizedView?.Invoke(this, EventArgs.Empty);
            };
            SignInBtn.Click += delegate
            {
                LoginEvent?.Invoke(this, EventArgs.Empty);
            };
        }



        private void LoginFrom_Load(object sender, EventArgs e)
        {

        }
    }
}
