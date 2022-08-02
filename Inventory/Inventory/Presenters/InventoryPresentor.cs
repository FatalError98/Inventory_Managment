using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using Inventory.Views;
using Inventory.Models;
using Inventory.Model;

namespace Inventory.Presenters
{
    public class InventoryPresentor
    {
        private IInventoryView _inventoryView;

        public InventoryPresentor(IInventoryView inventoryView)
        {
            _inventoryView = inventoryView;

            _inventoryView.Show();
        }
    }
}
