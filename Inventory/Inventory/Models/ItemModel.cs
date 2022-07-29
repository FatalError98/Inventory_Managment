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
    public class ItemModel
    {
        //Fields
        private int id;
        private string itemName;
        private string itemSupplier;
        private string itemCategory;
        private string itemSize;
        private int itemContain;
        private int itemQuantity;
        private double itemPrice;
        private double totalPrice;
        private DateTime addedDate;
        private string description;

        //Properties - Validation
        [DisplayName("ت")]
        public int Id 
        {
            get => id;
            set => id = value; 
        }
        [DisplayName("المادة")]
        [Required(ErrorMessage = "حقل المادة مطلوب, يجب ادخال اسم المادة")]
        public string ItemName 
        { 
            get => itemName; 
            set => itemName = value; 
        }
        [DisplayName("المصدر")]
        [Required(ErrorMessage = "حقل المصدر مطلوب, يجب ادخال مصدر المادة")]
        public string ItemSupplier 
        { 
            get => itemSupplier; 
            set => itemSupplier = value; 
        }
        [DisplayName("الفئة")]
        [Required(ErrorMessage = "حقل الفئة مطلوب, يجب ادخال فئة المادة")]
        public string ItemCategory 
        { 
            get => itemCategory; 
            set => itemCategory = value; 
        }
        [DisplayName("حجم المادة")]
        public string ItemSize 
        { 
            get => itemSize;
            set => itemSize = value; 
        }
        [DisplayName("محتويات")]
        public int ItemContain 
        { 
            get => itemContain; 
            set => itemContain = value; 
        }
        [DisplayName("الكمية")]
        [Required(ErrorMessage = "حقل الكمية مطلوب, يجب ادخال الكمية المدخلة للمادة")]
        [Range(1,9999)]
        public int ItemQuantity 
        { 
            get => itemQuantity; 
            set => itemQuantity = value; 
        }
        [DisplayName("المبلغ")]
        [Required(ErrorMessage = "حقل المبلغ مطلوب, يجب ادخال مبلغ للمادة المدخلة ")]
        public double ItemPrice 
        {
            get => itemPrice; 
            set => itemPrice = value; 
        }
        [DisplayName("المبلغ الكلي")]
        public double TotalPrice 
        { 
            get => totalPrice; 
            set => totalPrice = value;
        }
        [DisplayName("تاريخ الاضافة")]
        [Required(ErrorMessage = "حقل التاريخ مطلوب, ادخل تاريخ اضافة المادة ")]
        public DateTime AddedDate 
        {
            get => addedDate; 
            set => addedDate = value; 
        }
        [DisplayName("ملاحظات")]
        public string Description 
        {
            get => description; 
            set => description = value;
        }
    }
}
