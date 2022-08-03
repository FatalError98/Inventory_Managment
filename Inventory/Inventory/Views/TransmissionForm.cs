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
    public partial class TransmissionForm : Form, ITransmissionView
    {
        private string message;
        private bool isSuccessful;
        private bool isEdit;
        private int transmissionId = 0;

        public int TransmissionId
        {
            get => transmissionId;
            set => transmissionId = value;
        }
        public string TransmissionItem
        {
            get => itemTxt.Text;
            set => itemTxt.Text = value;
        }
        public string TransmissionCategory
        {
            get => categoryTxt.Text;
            set => categoryTxt.Text = value;
        }
        public int TransmissionQuantity
        {
            get => (int)quantityNumUpDown.Value;
            set => quantityNumUpDown.Value = value;
        }
        public string TransmissionBuilding
        {
            get => buildingComboBox.Text;
            set => buildingComboBox.Text = value;
        }
        public string TransmissionDepartment
        {
            get => departmentComboBox.Text;
            set => departmentComboBox.Text = value;
        }
        public string TransmissionDate
        {
            get => dateTimePicker.Text;
            set => dateTimePicker.Text = value;
        }
        public string TransmissionSearch
        {
            get => searchTxt.Text;
            set => searchTxt.Text = value;
        }
        public string Description
        {
            get => descriptionTxt.Text;
            set => descriptionTxt.Text = value;
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
        public TransmissionForm()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvent();
            transmissionUpdateTapControl.TabPages.Remove(transmissionUpdatePage);
        }
        private void AssociateAndRaiseViewEvent()
        {
            //Search Event
            searchBtn.Click += delegate
            {
                SearchEvent?.Invoke(this, EventArgs.Empty);
            };

            //Transmisstion New Item Event
            transmissionBtn.Click += delegate
            {
                TransmisstionEvent?.Invoke(this, EventArgs.Empty);
                transmissionUpdateTapControl.TabPages.Remove(transmissionUpdatePage);
                transmissionUpdateTapControl.TabPages.Add(transmissionUpdatePage);
                titleLabel.Text = "تسليم مادة جديدة";

            };

            //Update Transmited Item Event
            updateBtn.Click += delegate
            {
                UpdateEvent?.Invoke(this, EventArgs.Empty);
                transmissionUpdateTapControl.TabPages.Remove(transmissionUpdatePage);
                transmissionUpdateTapControl.TabPages.Add(transmissionUpdatePage);
                titleLabel.Text =  " تحديث البيانات المسلمة";
            };

            //Delete Transmission Event
            deleteBtn.Click += delegate
            {
                var result = MessageBox.Show("هل انت متاكد من حذف هذه المادة؟", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };

            //Save New User Event
            saveBtn.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    transmissionUpdateTapControl.TabPages.Remove(transmissionUpdatePage);
                }
                MessageBox.Show(Message);
            };

            //Cancel User Event
            cancelBtn.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                transmissionUpdateTapControl.TabPages.Remove(transmissionUpdatePage);
            };
        }

        public event EventHandler SearchEvent;
        public event EventHandler TransmisstionEvent;
        public event EventHandler UpdateEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;


        //Set binding Source to the Transmission
        public void SetTransmissionBindingSource(BindingSource transmissionList)
        {
            transmissionItemDataGridView.DataSource = transmissionList;
        }
        public void SetBuildingBindingSource(BindingSource buildingList)
        {
            buildingComboBox.DataSource = buildingList;
        }

        public void SetDepartmentBindingSource(BindingSource DepartmentList)
        {
            departmentComboBox.DataSource = DepartmentList;
        }

        private void TransmissionForm_Load(object sender, EventArgs e)
        {

        }

        private void transmissionUpdatePage_Click(object sender, EventArgs e)
        {

        }
    }
}
