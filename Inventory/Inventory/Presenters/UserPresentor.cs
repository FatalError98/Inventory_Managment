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
        private IEnumerable<UserModel> _usersModel;

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
            _usersModel = _usersRepository.GetAll();
            _userBindingSource.DataSource = _usersModel;
        }
        private void SearchUser(object sender, EventArgs e)
        {
            bool emptyValues = _userView.SearchValue == "";
            if (emptyValues != true)
                _usersModel = _usersRepository.GetByvalue(_userView.SearchValue);
            else
                _usersModel = _usersRepository.GetAll();
            _userBindingSource.DataSource = _usersModel;
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveUser(object sender, EventArgs e)
        {
            var model = new UserModel();
            model.Id = Convert.ToInt32(_userView.UserId);
            model.Name = _userView.UserName;
            model.Password = _userView.UserPassword;
            model.Role = _userView.UserRole;
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (_userView.IsEdit)
                {
                    _usersRepository.Update(model);
                    _userView.Message = "تم تحديث المستخدم بنجاح";
                }
                else
                {
                    _usersRepository.Add(model);
                    _userView.Message = "تم اضافة نستخدم بنجاح";
                }
                _userView.IsSuccessful = true;
                LoadAllUserList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                _userView.IsSuccessful = false;
                _userView.Message = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            _userView.UserName = "";
            _userView.UserPassword = "";
            _userView.UserRole = "";
        }

        private void DeleteSelectedUser(object sender, EventArgs e)
        {
            try
            {
                var user = (UserModel)_userBindingSource.Current;
                _usersRepository.Delete(user.Id);
                _userView.IsSuccessful = true;
                _userView.Message = "تم حذف المستخدم بنجاح";
                LoadAllUserList();
            }
            catch (Exception ex)
            {
                _userView.IsSuccessful = false;
                _userView.Message = ex.Message;
            }
        }

        private void LoadSelectedUsersToEdit(object sender, EventArgs e)
        {
            var users = (UserModel)_userBindingSource.Current;
            _userView.UserId = users.Id;
            _userView.UserName = users.Name.ToString();
            _userView.UserPassword = users.Password.ToString();
            _userView.UserRole = users.Role.ToString();
            _userView.IsEdit = true;
        }

        private void AddNewUser(object sender, EventArgs e)
        {
            _userView.IsEdit = false;

        }      
    }
}
