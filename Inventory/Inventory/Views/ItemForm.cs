using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory.Views
{
    public partial class ItemForm : Form, IItemView
    {
        private string message;
        private bool isSuccessful;
        private bool isEdit;
        private double totalPrice;
        private int itemId;
        private static ItemForm instance;
        public ItemForm()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvent();
            addUpdateTapControl.TabPages.Remove(addUpdatePage);
        }


        public int ItemId 
        { 
            get => itemId; 
            set => itemId = value; 
        }
        public string ItemName 
        { 
            get => itemTxt.Text; 
            set => itemTxt.Text = value; 
        }
        public string ItemSupplier 
        { 
            get => supplierTxt.Text; 
            set => supplierTxt.Text = value; 
        }
        public string ItemCategory 
        { 
            get => categoryTxt.Text; 
            set => categoryTxt.Text = value; 
        }
        public string ItemSize 
        { 
            get => sizeTxt.Text; 
            set => sizeTxt.Text = value; 
        }
        public int ItemContain 
        { 
            get => (int)containNumUpDown.Value; 
            set => containNumUpDown.Value = value; 
        }
        public int ItemQuantity 
        { 
            get => (int)quantityNumUpDown.Value; 
            set => quantityNumUpDown.Value = value; 
        }
        public double ItemPrice 
        {
            get => Convert.ToDouble(priceTxt.Text); 
            set => priceTxt.Text = value.ToString(); 
        }
        public double TotalPrice 
        { 
            get => totalPrice;
            set =>  totalPrice = Convert.ToDouble(priceTxt.Text) * (int)quantityNumUpDown.Value;            
        }
        public DateTime DateTime 
        { 
            get => dateTimePicker.MinDate; 
            set => dateTimePicker.MinDate = value; 
        }
        public string Description 
        { 
            get => descriptionTxt.Text; 
            set => descriptionTxt.Text = value; 
        }
        public string SearchValue 
        { 
            get => searchTxt.Text; 
            set => searchTxt.Text = value; 
        }
        public bool IsEdit 
        { 
            get => isEdit; 
            set => isEdit = value; 
        }
        public bool IsSuccessful 
        { 
            get => isSuccessful; 
            set => isSuccessful = value;
        }
        public string Message 
        { 
            get => message; 
            set => message = value;
        }

        //Events
        public event EventHandler SearchEvent;
        public event EventHandler AddEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        //associate the button to the events
        private void AssociateAndRaiseViewEvent()
        {
            searchBtn.Click += delegate
            {
                SearchEvent?.Invoke(this, EventArgs.Empty);
                
            };
            addBtn.Click += delegate
            {
                AddEvent?.Invoke(this, EventArgs.Empty);
                addUpdateTapControl.TabPages.Remove(addUpdatePage);
                addUpdateTapControl.TabPages.Add(addUpdatePage);
                titleLabel.Text = "اضافة مادة جديدة";
            };
            updateBtn.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                addUpdateTapControl.TabPages.Remove(addUpdatePage);
                addUpdateTapControl.TabPages.Add(addUpdatePage);
                titleLabel.Text = " تحديث المادة ";
            };
            deleteBtn.Click += delegate
            {
                var result = MessageBox.Show("هل انت متأكد من حذف هذه المادة","تحذير",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
               
            };
            saveBtn.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                   addUpdateTapControl.TabPages.Remove(addUpdatePage);
                }
                MessageBox.Show(Message);
            };
            cancelBtn.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                addUpdateTapControl.TabPages.Remove(addUpdatePage);
            };
        }
        public void SetItemBindingSource(BindingSource itemsSource)
        {
            itemsDataGridView.DataSource = itemsSource;
        }

        private void ItemForm_Load(object sender, EventArgs e)
        {

        }
        //Singleton Pattern (open a Signle Form instance)       
        public static ItemForm GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ItemForm();
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }
    }
}
