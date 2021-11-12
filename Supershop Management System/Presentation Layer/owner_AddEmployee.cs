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
    public partial class owner_AddEmployee : Form
    {
        BusinessLayer bl = new BusinessLayer();
        public owner_AddEmployee()
        {
            InitializeComponent();
        }

        private void owner_emp_update_button_Click(object sender, EventArgs e)
        {
           



            if (bl.TextCheck(employee_name_tb.Text) && bl.TextCheck(employee_address_tb.Text) && bl.TextCheck(employee_email_tb.Text) && bl.NumberCheck(employee_phoneNumber_tb.Text) && bl.NumberCheck(employee_nid_tb.Text) && bl.EmptyCheck(employee_name_tb.Text) && bl.EmptyCheck(employee_address_tb.Text) && bl.EmptyCheck(employee_email_tb.Text) && bl.EmptyCheck(employee_phoneNumber_tb.Text) && bl.EmptyCheck(employee_nid_tb.Text))
            {
                bl.InsertloginSSD(emp_sel_combobox.Text);

                int sid = bl.da.per.sid;
                bl.AddPerson(sid, employee_name_tb.Text, int.Parse(employee_phoneNumber_tb.Text), employee_address_tb.Text, employee_email_tb.Text, int.Parse(employee_nid_tb.Text));
                MessageBox.Show("New Salesman added", "Information");
                employee_name_tb.Text = employee_phoneNumber_tb.Text = employee_address_tb.Text = employee_email_tb.Text = employee_nid_tb.Text = string.Empty;
            }

            else
                return;

                


            


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Owner own = new Owner();

            this.Hide();

            own.Show();
        }

        private void owner_AddEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void owner_AddEmployee_Load(object sender, EventArgs e)
        {

        }
    }
    }

