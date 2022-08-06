using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// To Use Binding Source
using System.Windows.Forms;
//reference to the Model And the view
using Inventory.Models;
using Inventory.Views;

namespace Inventory.Presenters
{
    public class TransmissionPresentor
    {
        private ITransmissionView _transmissionView;
        private ITransmissionRepository _transmissionRepository;
        private BindingSource _transmissionBindingSource;     
        private IEnumerable<TransmissionModel> _transmissionModels;



        public TransmissionPresentor(ITransmissionView transmissionView, ITransmissionRepository treansmissionRepository)
        {
            _transmissionBindingSource = new BindingSource();

            _transmissionView = transmissionView;
            _transmissionRepository = treansmissionRepository;

            //Subscribe event handler methods to view events
            _transmissionView.SearchEvent += SearchTransmission;
            _transmissionView.TransmisstionEvent += TransmissionNewItem;
            _transmissionView.UpdateEvent += LoadSelectedUsersToEdit;
            _transmissionView.DeleteEvent += DeleteSelctedTransmission;
            _transmissionView.SaveEvent += SaveTransmission;
            _transmissionView.CancelEvent += CancelTransmission;

            //set transmission Binding source
            _transmissionView.SetTransmissionBindingSource(_transmissionBindingSource);

            //Load all data
            LoadAllTransmission();

            transmissionView.Show();
        }


        //Methods
        private void SearchTransmission(object sender, EventArgs e)
        {
            bool emptyValues = _transmissionView.TransmissionSearch == "";
            if (emptyValues != true)
                _transmissionModels = _transmissionRepository.GetByValue(_transmissionView.TransmissionSearch);
            else
                _transmissionModels = _transmissionRepository.GetAll();
            _transmissionBindingSource.DataSource = _transmissionModels;
        }
        private void TransmissionNewItem(object sender, EventArgs e)
        {
            CleanViewFields();
            _transmissionView.IsEdit = false;
        }
        private void LoadSelectedUsersToEdit(object sender, EventArgs e)
        {
            var transmission = (TransmissionModel)_transmissionBindingSource.Current;
            if (transmission != null)
            {
                _transmissionView.TransmissionId = transmission.Id;
                _transmissionView.TransmissionItem = transmission.ItemName.ToString();
                _transmissionView.TransmissionQuantity = transmission.Quantity;
                _transmissionView.TransmissionCategory = transmission.Category.ToString();
                _transmissionView.TransmissionDepartment = transmission.Department.ToString();
                _transmissionView.TransmissionBuilding = transmission.Building.ToString();
                _transmissionView.TransmissionDate = transmission.Date.ToString();
                _transmissionView.IsEdit = true;
            }
        }
        private void DeleteSelctedTransmission(object sender, EventArgs e)
        {
            try
            {
                var transmission = (TransmissionModel)_transmissionBindingSource.Current;
                if (transmission != null)
                {
                    _transmissionRepository.Delete(transmission.Id);
                    _transmissionView.IsSuccessful = true;
                    _transmissionView.Message = "تم حذف المادة بنجاح";
                    LoadAllTransmission();
                }
            }
            catch (Exception ex)
            {
                _transmissionView.IsSuccessful = false;
                _transmissionView.Message = ex.Message;
            }
        }
        private void SaveTransmission(object sender, EventArgs e)
        {
            var model = new TransmissionModel();
            model.Id = Convert.ToInt32(_transmissionView.TransmissionId);
            model.ItemName = _transmissionView.TransmissionItem;
            model.Quantity = Convert.ToInt32(_transmissionView.TransmissionQuantity);
            model.Category = _transmissionView.TransmissionCategory;
            model.Department = _transmissionView.TransmissionDepartment;
            model.Building = _transmissionView.TransmissionBuilding;
            model.Date = Convert.ToDateTime(_transmissionView.TransmissionDate);
            model.Description = _transmissionView.Description;
            model.Consumable = _transmissionView.Consumable;
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (_transmissionView.IsEdit)
                {
                    _transmissionRepository.Update(model);
                    _transmissionView.Message = "تم تحديث البيانات بنجاح";
                }
                else
                {
                    _transmissionRepository.Add(model);
                    _transmissionView.Message = "تم التسليم بنجاح";
                }
                _transmissionView.IsSuccessful = true;
                LoadAllTransmission();
                CleanViewFields();

            }
            catch (Exception ex)
            {
                _transmissionView.IsSuccessful = false;
                _transmissionView.Message = ex.Message;
            }
        }
        private void CancelTransmission(object sender, EventArgs e)
        {
            CleanViewFields();
        }
        private void LoadAllTransmission()
        {
            _transmissionModels = _transmissionRepository.GetAll();
            _transmissionBindingSource.DataSource = _transmissionModels;
        }
        private void CleanViewFields()
        {
            _transmissionView.TransmissionId = 0;
            _transmissionView.TransmissionItem = "";
            _transmissionView.TransmissionCategory = "";
            _transmissionView.TransmissionQuantity = 0;
            _transmissionView.TransmissionBuilding = "";
            _transmissionView.TransmissionDepartment = "";
            _transmissionView.TransmissionDate = "";
            _transmissionView.Consumable = "";
        }
        
    }
}
