using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using Inventory.Views;
using Inventory.Models;

namespace Inventory.Presenters
{
    public class SettingsPresentor
    {
        private ISettingsView _settingsView;

        public SettingsPresentor(ISettingsView settingsView)
        {
            _settingsView = settingsView;

            _settingsView.Show();
        }

        
    }
}
