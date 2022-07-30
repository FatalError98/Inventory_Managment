using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Views
{
    public interface ILoginView
    {
        //Properties - Fields
        string UserName { get; set; }
        string Password { get; set; }
        bool IsAdmin { get; set; } 
        bool IsSuccessful { get; set; } 
        string Message { get; set; }


        //evnets
        event EventHandler LoginEvent;
        event EventHandler CloseView;
        event EventHandler MinimizedView;
        event EventHandler MaximizedView;

        //Methods
        void Show();
    }
}
