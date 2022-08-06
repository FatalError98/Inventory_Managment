using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//To Use Binding Source
using System.Windows.Forms;

namespace Inventory.Views
{
    public interface ITransmissionView
    {
        //Properties - Fields
        int TransmissionId { get; set; }
        string TransmissionItem { get; set; }
        string TransmissionCategory { get; set; }
        int TransmissionQuantity { get; set; }
        string TransmissionBuilding { get; set; }
        string TransmissionDepartment { get; set; }
        string TransmissionDate { get; set; }
        string Description { get; set; }
        string TransmissionSearch { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }
        string Consumable { get; set; } 

        //Events
        event EventHandler SearchEvent;
        event EventHandler TransmisstionEvent;
        event EventHandler UpdateEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        //Methods
        void SetTransmissionBindingSource(BindingSource transmissionList);
        void SetBuildingBindingSource(BindingSource buildingList);
        void SetDepartmentBindingSource(BindingSource DepartmentList);
        void Show();
    }
}
