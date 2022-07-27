using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using Inventory.Views;
using Inventory.Model;
using Inventory._Repositories;
using System.Windows.Forms;

namespace Inventory.Presenters
{
    public class MainPresentor
    {
        private IMainView _mainView;
        private readonly string _sqlConnectionString;


        public MainPresentor(IMainView mainView, string sqlConnectionString)
        {
            _mainView = mainView;
            _sqlConnectionString = sqlConnectionString;

            this._mainView.ShowUsersView += ShowUserView;
        }
        private void ShowUserView(object sender, EventArgs e)
        {
            IUserView view = UsersForm.GetInstance((DashboardForm)_mainView);
            IUsersRepository repository = new UserRepository(_sqlConnectionString);
            new UserPresentor(view, repository);
        }

    }
}