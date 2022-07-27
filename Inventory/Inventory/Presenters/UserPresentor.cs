using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// To Use Binding Source
using System.Windows.Forms;
//reference to the Model And the view
using Inventory.Model;
using Inventory.Views;

namespace Inventory.Presenters
{
    public class UserPresentor
    {
        //Fields
        private IUserView _userView;
        private IUsersRepository _usersRepository;
        private BindingSource _userBindingSource;
        private IEnumerable<UserModel> _users;

        //Constructor
        public UserPresentor (IUserView userView, IUsersRepository usersRepository)
        {
            _userBindingSource = new BindingSource();
            _userView = userView;
            _usersRepository = usersRepository;

            //Subscribe event handler methods to view events
            _userView.SearchEvent += SearchUser;
            _userView.AddEvent += AddNewUser;
            _userView.EditEvent += LoadSelectedUsersToEdit;
            _userView.DeleteEvent += DeleteSelectedUser;
            _userView.SaveEvent += SaveUser;
            _userView.CancelEvent += CancelAction;

            //Set Users binding source
            _userView.SetUserListBindingSource(_userBindingSource);

            //Load Users List View
            LoadAllUserList();

            //Show View
            _userView.Show();


        }

        //Methods
        private void LoadAllUserList()
        {
            _users = _usersRepository.GetAll();
            _userBindingSource.DataSource = _users;
        }
        private void SearchUser(object sender, EventArgs e)
        {
            bool emptyValues = _userView.SearchValue == "";
            if (emptyValues != true)
                _users = _usersRepository.GetByvalue(_userView.SearchValue);
            else
                _users = _usersRepository.GetAll();
            _userBindingSource.DataSource = _users;
        }

        private void CancelAction(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SaveUser(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteSelectedUser(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelectedUsersToEdit(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewUser(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }      
    }
}
