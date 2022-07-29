using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Models
{
    public interface IItemRepository
    {
        void Add(ItemModel userModel);
        void Update(ItemModel userModel);
        void Delete(int id);
        IEnumerable<ItemModel> GetAll(); // Populate all Data
        IEnumerable<ItemModel> GetByvalue(string value); // For Search
    }
}
