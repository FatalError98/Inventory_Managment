using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Models
{
    public interface IUsersRepository
    {
        void Add(UserModel userModel);
        void Update(UserModel userModel);
        void Delete(int id);
        IEnumerable<UserModel> GetAll(); // Populate all Data
        IEnumerable<UserModel> GetByvalue(string value); // For Search

        bool GetByUserAndPassword(string name, string password); // Get Data By username and password
    }
}
