using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Models
{
    public class BuildingModel
    {
        private int id;
        private string building;

        public int Id 
        { 
            get => id; 
            set => id = value; 
        }
        public string Building 
        {
            get => building; 
            set => building = value; 
        }
    }
}
