using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Models
{
    public class DepartmentModel
    {
        private int id;
        private string department;

        public int Id
        {
            get => id;
            set => id = value;
        }
        public string Department
        {
            get => department;
            set => department = value;
        }
    }
}
