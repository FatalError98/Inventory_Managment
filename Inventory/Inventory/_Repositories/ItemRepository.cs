using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//To Use SQl
using System.Data;
using System.Data.SqlClient;
//refrense to Models
using Inventory.Models;
using Inventory.Model;
namespace Inventory._Repositories
{
    public class ItemRepository: BaseRepository,  IItemRepository
    {
        public ItemRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(ItemModel userModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ItemModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ItemModel> GetByvalue(string value)
        {
            throw new NotImplementedException();
        }

        public void Update(ItemModel userModel)
        {
            throw new NotImplementedException();
        }
    }
}
