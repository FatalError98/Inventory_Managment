using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Component to validate the data
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Models
{
    public class UserModel
    {
        //Fields
        private int id;
        private string name;
        private string password;
        private string role;

        //Properties - Validation
        [DisplayName("ت")]
        public int Id 
        { 
            get { return id; } 
            set { id = value; } 
        }

        [DisplayName("اسم المستخدم")]
        [Required(ErrorMessage = "اسم المستخدم مطلوب, يجب عليك ادخال اسم مستخدم")]      
        public string Name 
        { 
            get { return name; } 
            set { name = value; } 
        }

        [DisplayName("كلمة المرور")]
        [Required(ErrorMessage = "كلمة المرور مطلوب, يجب عليك ادخال كلمة مرور")]
        [StringLength(50, MinimumLength =1)]
        public string Password 
        { 
            get { return password; }
            set { password = value; } 
        }

        [DisplayName("دور المستخدم")]       
        public string Role 
        { 
            get { return role; } 
            set { role = value; } 
        }
    }
}
