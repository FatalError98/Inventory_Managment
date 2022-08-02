using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Windows.Forms;
using System.Drawing;
// 
using Inventory.Views;
using Inventory.Model;
using Inventory.Models;
using Inventory._Repositories;

namespace Inventory.Presenters
{
    public class LoginPresentor
    {
        private ILoginView _loginView;
        private readonly string _sqlConnectionString;
        private bool _isLoggedIn;
        private static LoginFrom instance;

        public LoginPresentor(ILoginView loginView, string sqlConnectionString)
        {
            
            _loginView = loginView;
            _sqlConnectionString = sqlConnectionString;

            _loginView.LoginEvent += Login;
        }

        private void MaximizedView(object sender, EventArgs e)
        {
            instance =  new LoginFrom();
            if (instance.WindowState == FormWindowState.Minimized)
                instance.WindowState = FormWindowState.Normal;
            instance.WindowState = FormWindowState.Maximized;
        }

        private void MinimizedView(object sender, EventArgs e)
        {
            instance = new LoginFrom();
            if(instance.WindowState == FormWindowState.Normal)
                instance.WindowState = FormWindowState.Minimized;
        }

        private void CloseView(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Login(object sender, EventArgs e)
        {            
            bool emptyUser = _loginView.UserName == "";
            bool emptyPassword = _loginView.Password == "";

            if(emptyUser!= true && emptyPassword != true)
            {
                IUsersRepository _userRepository = new UserRepository(_sqlConnectionString);
                _isLoggedIn = _userRepository.GetByUserAndPassword(_loginView.UserName, _loginView.Password);
                if(_isLoggedIn)
                {
                    _loginView.Hide();
                    IMainView view = new DashboardForm();
                    new MainPresentor(view, _sqlConnectionString);
                }
            }
            
        }
    }
}
