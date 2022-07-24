
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory.Theme;

namespace Inventory
{
    public partial class DashboardForm : Form
    {
        //Feilds
        private Button currentButton;
        private Form activeForm;

        //Constractor
        public DashboardForm()
        {
            InitializeComponent();
        }

        // Methods

        //Methods to Change the button color when Clicked
        private void ActiveButton (object btnSender)
        {
            if (btnSender != null) 
            {
                    if (currentButton != btnSender as Button)
                    {
                    DisableButton(currentButton);
                    currentButton = btnSender as Button;

                    //Null Safety Check Wont be null but C# like it
                        if (currentButton != null)
                        {
                        Color color = ColorTranslator.FromHtml(ThemeColor.myColor);
                            currentButton.BackColor = color;
                            currentButton.ForeColor = Color.White;
                            currentButton.Font = new System.Drawing.Font("Tajawal", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            LogoPanel.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                        titlePanel.BackColor = color;

                        }
                            
                    }                   
            }
        }
        //Methods to Change the button to discard changes When click on another Button
        private void DisableButton(Button previousBtn)
        {
            //Null Safety Check Wont be null but C# like it
            if (previousBtn != null)
            {
                previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                previousBtn.ForeColor = Color.GhostWhite;
                previousBtn.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }            
        }

        //Method to open form in a contianer Panel
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activeForm != null)
            {
              activeForm.Close();
            }
            ActiveButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.desktopPanel.Controls.Add(childForm);
            this.desktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            titleLabel.Text = childForm.Text;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.SettingsForm(), sender);
        }

        private void DashboardFrom_Load(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.HomeForm(), sender);
        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.ItemForm(), sender);
        }

        private void transferItemBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.TransmissionForm(), sender);
        }

        private void inventoryBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.InventoryForm(), sender);
        }

        private void usersBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.UsersForm(), sender);
        }

        private void desktopPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
