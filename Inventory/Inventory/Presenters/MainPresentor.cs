﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Windows.Forms;
using System.Drawing;
// 
using Inventory.Views;
using Inventory.Models;
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
            _mainView.ShowItemView += ShowItemView;
            _mainView.ShowTransmissionView += ShowTransmissionView;
            _mainView.ShowSettingsView += ShowSettingsView;
            _mainView.ShowInventoryView += ShowInventoryView;

            _mainView.ChangeActiveButtonColor += ActiveButton;
            _mainView.Show();
        }

        private void ShowInventoryView(object sender, EventArgs e)
        {
            IInventoryView view = new InventoryForm();
            new InventoryPresentor(view);
            
        }

        private void ShowSettingsView(object sender, EventArgs e)
        {
            ISettingsView view = new SettingsForm();
            new SettingsPresentor(view);
        }

        private void ShowTransmissionView(object sender, EventArgs e)
        {
            ITransmissionView view = new TransmissionForm();
            ITransmissionRepository repository = new TransmissionRepository(_sqlConnectionString);
            new TransmissionPresentor(view, repository);
        }

        private void ShowItemView(object sender, EventArgs e)
        {
            IItemView view = new ItemForm();
            IItemRepository repository = new ItemRepository(_sqlConnectionString);
            new ItemPresentor(view, repository);
        }

        private void ShowUserView(object sender, EventArgs e)
        {
            IUserView view = new UsersForm();
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
                    _currentButton = (Button)sender;

                    //Null Safety Check Wont be null but C# like it
            if (_currentButton != null)
                    {
                        //Color color = ColorTranslator.FromHtml(ThemeColor.myColor);
                        _currentButton.ForeColor = Color.FromArgb(116,86,174);
                        _currentButton.BackColor = Color.White;
                        _currentButton.FlatAppearance.BorderColor = Color.FromArgb(116, 86, 174);
                        _currentButton.FlatAppearance.BorderSize = 1;
                        _currentButton.Font = new System.Drawing.Font("Tajawal", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    }

                }
            }
        }
        private void DisableButton(Button previousBtn)
        {
            //Null Safety Check Wont be null but C# like it
            if (previousBtn != null)
            {
                previousBtn.BackColor = Color.FromArgb(116, 86, 174);
                previousBtn.ForeColor = Color.White;
                previousBtn.Font = new System.Drawing.Font("Tajawal", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }
    }
}