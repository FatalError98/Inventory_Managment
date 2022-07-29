using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory.Views
{
    public interface IUserView
    {
        // Properties - Fields
        string UserId { get; set; }
        string UserName { get; set; }
        string UserPassword { get; set; }
        string UserRole { get; set; }   
        string SearchValue { get; set; }   
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        // Events
        event EventHandler SearchEvent;
        event EventHandler AddEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        //Methods
        void SetUserListBindingSource(BindingSource userList);
        void Show();
    }
}
