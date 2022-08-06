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
    public partial class UsersForm : Form, IUserView
    {
        private string message;
        private bool isSuccessful;
        private bool isEdit;
        private int userId;

        public int UserId 
        {
            get { return userId; }
            set {userId = value; }
        }
        public string UserName 
        {
            get { return userNameTxt.Text; }
            set {userNameTxt.Text = value; }
        }
        public string UserPassword
        {
            get { return passwordTxt.Text; }
            set { passwordTxt.Text = value;}
        }
        public string UserRole 
        {
            get { return userRoleComboBox.Text; }
            set { userRoleComboBox.Text = value; } 
        }
        public string SearchValue
        {
            get { return searchTxt.Text; }
            set { searchTxt.Text = value; }
        }
        public bool IsEdit 
        {
            get { return isEdit; } 
            set { isEdit = value; }
        }
        public bool IsSuccessful 
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }
        public string Message 
        {
            get { return message; }
            set { message = value; }
        }

        public UsersForm()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvent();
            usersTapControl.TabPages.Remove(usersPage);
        }

        private void AssociateAndRaiseViewEvent()
        {
            // Search Event
            searchBtn.Click += delegate{ SearchEvent?.Invoke(this, EventArgs.Empty); };
            searchTxt.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };
            //Add New User Event
            addNewBtn.Click += delegate { 
                AddEvent?.Invoke(this, EventArgs.Empty);
                usersTapControl.TabPages.Remove(usersPage);
                usersTapControl.TabPages.Add(usersPage);
                usersPage.Text = "اضافة مستخدم جديد";
            };
            //Edit exisiting  User Event
            updateBtn.Click += delegate { 
                EditEvent?.Invoke(this, EventArgs.Empty);
                usersTapControl.TabPages.Remove(usersPage);
                usersTapControl.TabPages.Add(usersPage);
                usersPage.Text = "تعديل بيانات مستخدم";
            };
            //Delete  User Event
            deleteBtn.Click += delegate {
               ;
               var  result = MessageBox.Show("هل انت متاكد من حذف هذا المستخدم؟", "تحذير", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if(result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
            //Save New User Event
            saveBtn.Click += delegate { 
                SaveEvent?.Invoke(this, EventArgs.Empty); 
                if(isSuccessful)
                {
                    usersTapControl.TabPages.Remove(usersPage);
                    usersTapControl.TabPages.Add(usersPage);
                }
                MessageBox.Show(Message);
            };
            //Cancel User Event
            cancelBtn.Click += delegate { 
                CancelEvent?.Invoke(this, EventArgs.Empty);
                usersTapControl.TabPages.Remove(usersPage);
                usersTapControl.TabPages.Add(usersPage);
            };
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        private void UsersForm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void SetUserListBindingSource(BindingSource userList)
        {
            usersDataGridView.DataSource = userList;
        }

        //Singleton Pattern (open a Signle Form instance)
        private static UsersForm instance;
        public static UsersForm GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new UsersForm();
                instance.TopLevel = false;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
                instance.MdiParent = parentContainer;
            }         
            else
            {
                if(instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void userNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
