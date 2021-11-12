using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Supershop_Management_System.Business_Layer;

namespace Supershop_Management_System.Presentation_Layer
{
    public partial class ManagerInfoUpdate : Form
    {
        BusinessLayer bl = new BusinessLayer();
        public ManagerInfoUpdate()
        {
            InitializeComponent();
        }

        private void updt_man_info_button_Click(object sender, EventArgs e)
        {
           // ManagerProfile mgp = new ManagerProfile();

            //mgp.Show();
           // this.Hide();
        }

        private void ManagerInfoUpdate_Load(object sender, EventArgs e)
        {
            int sid = FrontPage.nowId;

            bl.PersonUpdatePage(sid);

            manager_shopID_label.Text = Convert.ToString(sid);

            manager_name_textbox.Text = bl.da.upPerson.Name;

            manager_email_textbox.Text = bl.da.upPerson.Email;

            manager_fon_textbox.Text = Convert.ToString(bl.da.upPerson.Phone);

            manager_address_textbox.Text = bl.da.upPerson.Address;

            manager_password_textbox.Text = Convert.ToString(bl.da.upPerson.pass);

            manager_reent_pass_tb.Text = Convert.ToString(bl.da.upPerson.pass);

            manager_nid_tb.Text = Convert.ToString(bl.da.upPerson.Nid);








        }

        private void manager_info_update_button_Click(object sender, EventArgs e)
        {
            if (bl.TextCheck(manager_name_textbox.Text) && bl.TextCheck(manager_address_textbox.Text) && bl.TextCheck(manager_email_textbox.Text) && bl.NumberCheck(manager_fon_textbox.Text) && bl.NumberCheck(manager_nid_tb.Text) && bl.EmptyCheck(manager_name_textbox.Text) && bl.EmptyCheck(manager_address_textbox.Text) && bl.EmptyCheck(manager_email_textbox.Text) && bl.EmptyCheck(manager_fon_textbox.Text) && bl.EmptyCheck(manager_nid_tb.Text))
            {
                if (MessageBox.Show("Do You Want to Update Your Personal Info?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    bl.UpdatePersonInfo(int.Parse(manager_shopID_label.Text), manager_name_textbox.Text, int.Parse(manager_fon_textbox.Text), manager_address_textbox.Text, manager_email_textbox.Text, int.Parse(manager_nid_tb.Text));
                    if (manager_password_textbox.Text == manager_reent_pass_tb.Text)
                    {
                        bl.UpdateLoginInfo(int.Parse(manager_shopID_label.Text), int.Parse(manager_password_textbox.Text), "manager");
                    }

                    else
                    {
                        MessageBox.Show("Password Does not Match", "Warning");
                        return;
                    }
                }
            }
                
        }

        private void ManagerInfoUpdate_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
