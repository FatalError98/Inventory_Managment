using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Views
{
    public interface IMainView
    {
        event EventHandler ShowItemView;
        event EventHandler ShowTransmissionView;
        event EventHandler ShowInventoryView;
        event EventHandler ShowUsersView;          
        event EventHandler ShowSettingsView;       
    }
}
