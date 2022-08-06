using System;
using System.Collections.Generic;
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
    public class ItemPresentor
    {
        //Fields
        private IItemView _itemview;
        private IItemRepository _itemRepository;
        private BindingSource _itemBindingSource;
        private IEnumerable<ItemModel> _itemsModel;

        public ItemPresentor(IItemView itemview, IItemRepository itemRepository)
        {
            _itemBindingSource = new BindingSource();
            _itemview = itemview;
            _itemRepository = itemRepository;

            _itemview.SearchEvent += SearchItem;
            _itemview.AddEvent += AddNewItem;
            _itemview.EditEvent += LoadSelectedItemToEdit;
            _itemview.DeleteEvent += DeleteSelectedIteml;
            _itemview.SaveEvent += SaveItem;
            _itemview.CancelEvent += CancelAction;

            //Set Items Binding Source
            _itemview.SetItemBindingSource(_itemBindingSource);

            // Load All Item TO data Grid View
            LoadAllItem();

            //Show View
            _itemview.Show();
        }

        private void CleanViewFields()
        {
            _itemview.ItemId = 0;
            _itemview.ItemName = "";
            _itemview.ItemSupplier ="";
            _itemview.ItemCategory = "";
            _itemview.ItemSize = "";
            _itemview.ItemContain = 0;
            _itemview.ItemQuantity = 0;
            _itemview.ItemPrice = 0.0;
            _itemview.TotalPrice = 0.0;
            _itemview.DateTime = "";
            _itemview.Description = "";
        }


        private void LoadAllItem()
        {
            _itemsModel = _itemRepository.GetAll();
            _itemBindingSource.DataSource = _itemsModel;
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveItem(object sender, EventArgs e)
        {
            var model = new ItemModel();
            model.Id = _itemview.ItemId;
            model.ItemName = _itemview.ItemName;
            model.ItemSupplier = _itemview.ItemSupplier;
            model.ItemCategory = _itemview.ItemCategory;
            model.ItemSize = _itemview.ItemSize;
            model.ItemContain = _itemview.ItemContain;
            model.ItemQuantity = _itemview.ItemQuantity;
            model.ItemPrice = _itemview.ItemPrice;
            model.TotalPrice = _itemview.TotalPrice;
            model.AddedDate = Convert.ToDateTime(_itemview.DateTime);
            model.Description = _itemview.Description;
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (_itemview.IsEdit)
                {
                    _itemRepository.Update(model);
                    _itemview.Message = "تم تحديث البيانات بنجاح";
                }
                else
                {
                    _itemRepository.Add(model);
                    _itemview.Message = "تم اضافة المادة بنجاح";
                }
                _itemview.IsSuccessful = true;
                LoadAllItem();
                CleanViewFields();
                
            }
            catch (Exception ex)
            {
                _itemview.IsSuccessful = false;
                _itemview.Message = ex.Message;
            }

        }

        private void DeleteSelectedIteml(object sender, EventArgs e)
        {
            try
            {
                var item = (ItemModel)_itemBindingSource.Current;
                _itemRepository.Delete(item.Id);
                _itemview.IsSuccessful = true;
                _itemview.Message = "تم حذف المادة بنجاح";
                LoadAllItem();
            }
            catch (Exception ex)
            {
                _itemview.IsSuccessful = false;
                _itemview.Message = ex.Message;
            }
        }

        private void LoadSelectedItemToEdit(object sender, EventArgs e)
        {
            var item = (ItemModel)_itemBindingSource.Current;
            _itemview.ItemId = item.Id;
            _itemview.ItemName = item.ItemName;
            _itemview.ItemSupplier = item.ItemSupplier;
            _itemview.ItemCategory = item.ItemCategory;
            _itemview.ItemSize = item.ItemSize;
            _itemview.ItemContain = item.ItemContain;
            _itemview.ItemQuantity = item.ItemQuantity;
            _itemview.ItemPrice = item.ItemPrice;
            _itemview.TotalPrice = item.TotalPrice;
            _itemview.DateTime = item.AddedDate.ToString();
            _itemview.Description = item.Description;
            _itemview.IsEdit = true;
        }


        private void AddNewItem(object sender, EventArgs e)
        {
            CleanViewFields();
            _itemview.IsEdit = false;
        }

        private void SearchItem(object sender, EventArgs e)
        {
            bool emptyValues = _itemview.SearchValue == "";
            if (!emptyValues)
                _itemsModel = _itemRepository.GetByvalue(_itemview.SearchValue);
            else
                _itemsModel = _itemRepository.GetAll();
            _itemBindingSource.DataSource = _itemsModel;
        }
    }
}
