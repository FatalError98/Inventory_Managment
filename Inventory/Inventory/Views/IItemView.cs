using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Inventory.Views
{
    public interface IItemView
    {
        // Properties - Fields
        string ItemId { get; set; }
        string ItemName { get; set; }   
        string ItemSupplier { get; set; }
        string ItemCategory { get; set; }
        string ItemSize { get; set; }   
        int ItemContain { get; set; }
        int ItemQuantity { get; set; }
        double ItemPrice { get; set; }
        double TotalPrice { get; set; }
        DateTime DateTime { get; set; }
        string Description { get; set; }
        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        //Events
        event EventHandler SearchEvent;
        event EventHandler AddEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        //Methods
        void SetItemBindingSource(BindingSource itemsSource);
        void Show();
    }
}
