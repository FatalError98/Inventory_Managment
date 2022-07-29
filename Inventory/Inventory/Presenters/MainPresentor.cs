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
using Inventory._Repositories;
using Inventory.Theme;


namespace Inventory.Presenters
{
    public class MainPresentor
    {
        private IMainView _mainView;
        private readonly string _sqlConnectionString;
        private Button _currentButton;

        public MainPresentor(IMainView mainView, string sqlConnectionString)
        {
            _mainView = mainView;
            _sqlConnectionString = sqlConnectionString;

            _mainView.ShowUsersView += ShowUserView;
            _mainView.ChangeActiveButtonColor += ActiveButton;
        }
        private void ShowUserView(object sender, EventArgs e)
        {
            IUserView view = UsersForm.GetInstance((DashboardForm)_mainView);
            IUsersRepository repository = new UserRepository(_sqlConnectionString);
            new UserPresentor(view, repository);
        }

        private void ActiveButton(object sender, EventArgs e)
        {
            if (sender != null)
            {
                if (_currentButton != sender)
                {
                    DisableButton(_currentButton);
                    _currentButton = sender as Button;

                    //Null Safety Check Wont be null but C# like it
            if (_currentButton != null)
                    {
                        Color color = ColorTranslator.FromHtml(ThemeColor.myColor);
                        _currentButton.BackColor = color;
                        _currentButton.ForeColor = Color.White;
                        _currentButton.Font = new System.Drawing.Font("Tajawal", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    }

                }
            }
        }

        private void DisableButton(Button previousBtn)
        {
            //Null Safety Check Wont be null but C# like it
            if (previousBtn != null)
            {
                previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                previousBtn.ForeColor = Color.GhostWhite;
                previousBtn.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }
    }
}