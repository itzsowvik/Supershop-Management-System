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
    public partial class manager_emp_update_info : Form
    {

        BusinessLayer bl = new BusinessLayer();

        public manager_emp_update_info()
        {
            InitializeComponent();
        }

        private void manager_emp_update_info_Load(object sender, EventArgs e)
        {
            //public bool UpdatepersonInfo(int sid, string name, int phone, string address, string email, int nid)



            bl.PersonUpdatePage(FrontPage.nowId);


            manager_id_label.Text = Convert.ToString(FrontPage.nowId);

            manager_name_textbox.Text = bl.da.upPerson.Name;

            manager_email_textbox.Text = bl.da.upPerson.Email;

            manager_fon_textbox.Text = Convert.ToString(bl.da.upPerson.Phone);

            manager_address_textbox.Text = bl.da.upPerson.Address;

            manager_password_textbox.Text = Convert.ToString(bl.da.upPerson.pass);

            manager_nid_textbox.Text = Convert.ToString(bl.da.upPerson.Nid);



            

         

            

                 







        }

        private void manager_info_update_button_Click(object sender, EventArgs e)
        {
            if (bl.TextCheck(manager_name_textbox.Text) && bl.TextCheck(manager_address_textbox.Text) && bl.TextCheck(manager_email_textbox.Text) && bl.NumberCheck(manager_fon_textbox.Text) && bl.NumberCheck(manager_nid_textbox.Text) && bl.EmptyCheck(manager_name_textbox.Text) && bl.EmptyCheck(manager_address_textbox.Text) && bl.EmptyCheck(manager_email_textbox.Text) && bl.EmptyCheck(manager_fon_textbox.Text) && bl.EmptyCheck(manager_nid_textbox.Text))
            {
                if (MessageBox.Show("Do You Want to Update Your Personal Info?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {


                    bl.UpdateLoginInfo(int.Parse(manager_id_label.Text), int.Parse(manager_password_textbox.Text), "manager");
                    bl.UpdatePersonInfo(FrontPage.nowId, manager_name_textbox.Text, int.Parse(manager_fon_textbox.Text), manager_address_textbox.Text, manager_email_textbox.Text, int.Parse(manager_nid_textbox.Text));



                }
            }

           
            }

        private void button1_Click(object sender, EventArgs e)
        {
            Manager man = new Manager();

            man.Show();

            this.Hide();
        }

        private void manager_emp_update_info_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
