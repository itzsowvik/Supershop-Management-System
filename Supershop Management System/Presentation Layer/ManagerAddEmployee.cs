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
    public partial class ManagerAddEmployee : Form
    {
        BusinessLayer bl = new BusinessLayer();
        public ManagerAddEmployee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manager mgr = new Manager();

            mgr.Show();

            this.Hide();
        }

        private void owner_emp_update_button_Click(object sender, EventArgs e)
        {
            

            if (bl.TextCheck(addemp_name_tb.Text) && bl.TextCheck(addemp_tb.Text) && bl.TextCheck(addemp_email_tb.Text) && bl.NumberCheck(addemp_phone_tb.Text) && bl.NumberCheck(addemp_nid_tb.Text) && bl.EmptyCheck(addemp_tb.Text) && bl.EmptyCheck(addemp_name_tb.Text) && bl.EmptyCheck(addemp_phone_tb.Text) && bl.EmptyCheck(addemp_email_tb.Text) && bl.EmptyCheck(addemp_nid_tb.Text))
            {
                bl.InsertloginSSD(label2.Text);

                int sid = bl.da.per.sid;
                bl.AddPerson(sid, addemp_name_tb.Text, int.Parse(addemp_phone_tb.Text), addemp_tb.Text, addemp_email_tb.Text, int.Parse(addemp_nid_tb.Text));
                addemp_name_tb.Text = addemp_phone_tb.Text = addemp_tb.Text = addemp_email_tb.Text = addemp_nid_tb.Text = string.Empty;
                MessageBox.Show("New Salesman added", "Information");
            }

               


            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ManagerAddEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
