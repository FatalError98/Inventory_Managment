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

            _itemview.SetItemBindingSource(_itemBindingSource);

            _itemview.Show();
        }
    }
}
