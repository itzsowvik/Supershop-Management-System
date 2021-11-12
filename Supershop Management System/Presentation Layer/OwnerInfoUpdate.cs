using Supershop_Management_System.Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supershop_Management_System.Presentation_Layer
{
    public partial class OwnerInfoUpdate : Form
    {
        BusinessLayer bl = new BusinessLayer();
        public OwnerInfoUpdate()
        {
            InitializeComponent();
        }

        private void OwnerInfoUpdate_Load(object sender, EventArgs e)
        {

            bl.PersonUpdatePage(FrontPage.nowId);


            ownr_id_label.Text = Convert.ToString(FrontPage.nowId);

            owner_name_textbox.Text = bl.da.upPerson.Name;

            owner_email_textbox.Text = bl.da.upPerson.Email;

            owner_personal_fon_textbox.Text = Convert.ToString(bl.da.upPerson.Phone);

            owner_address_textbox.Text = bl.da.upPerson.Address;

            owner_password_textbox.Text = Convert.ToString(bl.da.upPerson.pass);

            owner_nid_textbox.Text = Convert.ToString(bl.da.upPerson.Nid);
        }

        private void owner_info_update_button_Click(object sender, EventArgs e)
        {
            if (bl.TextCheck(owner_name_textbox.Text) && bl.TextCheck(owner_address_textbox.Text) && bl.TextCheck(owner_email_textbox.Text) && bl.NumberCheck(owner_personal_fon_textbox.Text) && bl.NumberCheck(owner_nid_textbox.Text) && bl.EmptyCheck(owner_name_textbox.Text) && bl.EmptyCheck(owner_address_textbox.Text) && bl.EmptyCheck(owner_email_textbox.Text) && bl.EmptyCheck(owner_personal_fon_textbox.Text) && bl.EmptyCheck(owner_nid_textbox.Text))
            {
                if (MessageBox.Show("Do You Want to Update Your Personal Info?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {


                    bl.UpdateLoginInfo(FrontPage.nowId, int.Parse(owner_password_textbox.Text), "owner");
                    bl.UpdatePersonInfo(FrontPage.nowId, owner_name_textbox.Text, int.Parse(owner_personal_fon_textbox.Text), owner_address_textbox.Text, owner_email_textbox.Text, int.Parse(owner_nid_textbox.Text));



                }
            }
               
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Owner own = new Owner();

            own.Show();

            this.Hide();
        }

        private void OwnerInfoUpdate_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
    }

