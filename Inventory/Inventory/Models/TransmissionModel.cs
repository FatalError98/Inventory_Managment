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
    public class TransmissionModel
    {
        //Fields
        private int _id;
        private string _item;
        private string _category;
        private int _quantity;
        private string _department;
        private string _building;
        private DateTime _date;
        private string _description;
        private string _consumable;

        [DisplayName("ت")]
        public int Id
        {
            get => _id;
            set => _id = value;
        }
        [DisplayName("المادة")]
        [Required(ErrorMessage = "اسم المادة مطلوب, يجب عليك ادخال اسم المادة")]
        [StringLength(255, MinimumLength = 1)]
        public string ItemName
        {
            get => _item;
            set => _item = value;
        }
        [DisplayName("الكمية")]
        [Required(ErrorMessage = "الكمية المسلمة مطلوبة, يجب عليك ادخال الكمية المسلمة")]
        [Range(1, 9999)]
        public int Quantity
        {
            get => _quantity;
            set => _quantity = value;
        }

        [DisplayName("الفئة")]
        [Required(ErrorMessage = "فئة المادة مطلوبة, يجب عليك ادخال الفئة الخاصة بهذه المادة")]
        [StringLength(255, MinimumLength = 1)]
        public string Category
        {
            get => _category;
            set => _category = value;
        }
        [DisplayName("القسم")]
        [Required(ErrorMessage = " القسم مطلوب, يجب عليك ادخال القسم المسلم له ")]
        public string Department
        {
            get => _department;
            set => _department = value;
        }
        [DisplayName("البناية")]
        [Required(ErrorMessage = "البناية مطلوبة , يجب عليك ادخال البناية المسلم لها")]
        public string Building
        {
            get => _building;
            set => _building = value;
        }
        [DisplayName("تاريخ التسليم")]
        [Required(ErrorMessage = "اسم المادة مطلوب, يجب عليك ادخال اسم المادة")]
        public DateTime Date
        {
            get => _date;
            set => _date = value;
        }
        [DisplayName("ملاحظات")]
        public string Description
        {
            get => _description;
            set => _description = value;
        }
        [DisplayName("استهلاك")]
        public string Consumable
        {
            get => _consumable;
            set => _consumable = value;
        }
    }
}
