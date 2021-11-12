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
    public partial class Owner_EmployeeInformaton : Form
    {
        BusinessLayer bl = new BusinessLayer();
        DataTable ab;
       
        public Owner_EmployeeInformaton()
        {
            InitializeComponent();
        }

        private void Owner_EmployeeInformaton_Load(object sender, EventArgs e)
        {
            empInfoDataGridview.DataSource = bl.empsInfo();
        }

        private void owner_employee_search_button_Click(object sender, EventArgs e)
        {

            if (bl.NumberCheck(empID_tb.Text))
            {
                ab = bl.EmployeeSearch(int.Parse(empID_tb.Text));
            }

            //upPerson.Name = Convert.ToString(dt.Rows[0][1]);



            empName_tb.Text = ab.Rows[0][1].ToString();

            empAddress_tb.Text = ab.Rows[0][3].ToString();

            emp_phone_tb.Text = ab.Rows[0][2].ToString();

            emp_email_tb.Text = ab.Rows[0][4].ToString();

            emp_NID_tb.Text = ab.Rows[0][5].ToString();
        }

        private void owner_emp_update_button_Click(object sender, EventArgs e)
        {
            if(bl.TextCheck(empName_tb.Text) && bl.TextCheck(empAddress_tb.Text) && bl.TextCheck(emp_email_tb.Text) && bl.NumberCheck(empID_tb.Text) && bl.NumberCheck(emp_phone_tb.Text) && bl.NumberCheck(emp_NID_tb.Text) && bl.EmptyCheck(empName_tb.Text) && bl.EmptyCheck(empAddress_tb.Text) && bl.EmptyCheck(emp_email_tb.Text) && bl.EmptyCheck(empID_tb.Text) && bl.EmptyCheck(emp_phone_tb.Text) && bl.EmptyCheck(emp_NID_tb.Text))
            {
                if (MessageBox.Show("Do You Want to Update Your Personal Info?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    bl.UpdatePersonInfo(int.Parse(empID_tb.Text), empName_tb.Text, int.Parse(emp_phone_tb.Text), empAddress_tb.Text, emp_email_tb.Text, int.Parse(emp_NID_tb.Text));
                    MessageBox.Show("Information Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    empInfoDataGridview.DataSource = bl.da.salesInfo();
                    return;
                }
            }

            
             
        }

        private void owner_remove_employee_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Want to Delete Employee?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                bl.DeletePersonInformation(int.Parse(empID_tb.Text));
                bl.DeleteLoginInfo(int.Parse(empID_tb.Text));

                MessageBox.Show("Person Deleted", "Information");
                empInfoDataGridview.DataSource = bl.da.salesInfo();


                empID_tb.Text = empName_tb.Text = empAddress_tb.Text = emp_phone_tb.Text = emp_email_tb.Text = emp_NID_tb.Text = String.Empty;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Owner own = new Owner();

            own.Show();
            this.Hide();
        }

        private void Owner_EmployeeInformaton_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
    }

