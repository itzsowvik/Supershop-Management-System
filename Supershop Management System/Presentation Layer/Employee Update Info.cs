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
    public partial class Employee_Update_Info : Form
    {


        BusinessLayer bl = new BusinessLayer();
        public Employee_Update_Info()
        {
            InitializeComponent();


        }



        private void Employee_Update_Info_FormClosing(object sender, FormClosingEventArgs e)
        {
            Employee_Update_Info eui = new Employee_Update_Info();

            eui.Close();
        }

        private void Employee_Update_Info_Load(object sender, EventArgs e)
        {
            

            int sid = FrontPage.nowId;

            bl.PersonUpdatePage(sid);

            emp_id_label.Text = Convert.ToString(sid);

            emp_name_label.Text = bl.da.upPerson.Name;

            emp_updt_email_tb.Text = bl.da.upPerson.Email;

            emp_updt_phone_tb.Text = Convert.ToString(bl.da.upPerson.Phone);

             emp_updt_address_tb.Text = bl.da.upPerson.Address;

            emp_updt_pass_tb.Text= Convert.ToString(bl.da.upPerson.pass);

            emp_updt_re_ent_pass_tb.Text= Convert.ToString(bl.da.upPerson.pass);

            emp_upd_nid_tb.Text = Convert.ToString(bl.da.upPerson.Nid);








        }

        private void emp_back_button_Click(object sender, EventArgs e)
        {
            //Employee_Update_Info eui = new Employee_Update_Info();

            Employee emp = new Employee();

            //emp.Show();
            this.Hide();

        }

        private void update_button_Click(object sender, EventArgs e)
        {

            if (bl.TextCheck(emp_updt_email_tb.Text) && bl.TextCheck(emp_updt_address_tb.Text) && bl.NumberCheck(emp_updt_phone_tb.Text) && bl.NumberCheck(emp_upd_nid_tb.Text) && bl.EmptyCheck(emp_updt_email_tb.Text) && bl.EmptyCheck(emp_updt_address_tb.Text) && bl.EmptyCheck(emp_updt_phone_tb.Text) && bl.EmptyCheck(emp_upd_nid_tb.Text))
            {
                if (MessageBox.Show("Do You Want to Update Your Personal Info?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {

                    if (emp_updt_pass_tb.Text == emp_updt_re_ent_pass_tb.Text)
                    {
                        bl.UpdateLoginInfo(int.Parse(emp_id_label.Text), int.Parse(emp_updt_pass_tb.Text), "salesman");
                        bl.UpdatePersonInfo(FrontPage.nowId, emp_name_label.Text, int.Parse(emp_updt_phone_tb.Text), emp_updt_address_tb.Text, emp_updt_email_tb.Text, int.Parse(emp_upd_nid_tb.Text));
                    }


                    else
                    {
                        MessageBox.Show("Password Does not Match", "Warning");
                        return;
                    }
                }
            }
                

            
           
        }
    }
}
