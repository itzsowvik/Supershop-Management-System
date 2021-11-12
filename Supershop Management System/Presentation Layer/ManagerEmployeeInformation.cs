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
    public partial class ManagerEmployeeInformation : Form
    {
        BusinessLayer bl = new BusinessLayer();
        DataTable ab;

        public ManagerEmployeeInformation()
        {
            InitializeComponent();
        }

        private void ManagerEmployeeInformation_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource= bl.salesInfo();

        }

        private void owner_employee_search_button_Click(object sender, EventArgs e)
        {
            if(bl.NumberCheck(emp_id_tb.Text))
            {
                 ab = bl.EmployeeSearch(int.Parse(emp_id_tb.Text));
            }
           

            //upPerson.Name = Convert.ToString(dt.Rows[0][1]);

            emp_name_tb.Text = ab.Rows[0][1].ToString();

            emp_add_tb.Text = ab.Rows[0][3].ToString();

            emp_phone_tb.Text = ab.Rows[0][2].ToString();

            emp_email_tb.Text = ab.Rows[0][4].ToString();

            emp_nid_tb.Text = ab.Rows[0][5].ToString();
        }

        private void owner_emp_update_button_Click(object sender, EventArgs e)
        {
            if (bl.TextCheck(emp_name_tb.Text) && bl.TextCheck(emp_add_tb.Text) && bl.TextCheck(emp_email_tb.Text) && bl.NumberCheck(emp_id_tb.Text) && bl.NumberCheck(emp_phone_tb.Text) && bl.NumberCheck(emp_nid_tb.Text) && bl.EmptyCheck(emp_name_tb.Text) && bl.EmptyCheck(emp_add_tb.Text) && bl.EmptyCheck(emp_email_tb.Text) && bl.EmptyCheck(emp_id_tb.Text) && bl.EmptyCheck(emp_phone_tb.Text) && bl.EmptyCheck(emp_nid_tb.Text))
            {
                if (MessageBox.Show("Do You Want to Update Your Personal Info?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    bl.UpdatePersonInfo(int.Parse(emp_id_tb.Text), emp_name_tb.Text, int.Parse(emp_phone_tb.Text), emp_add_tb.Text, emp_email_tb.Text, int.Parse(emp_nid_tb.Text));
                    MessageBox.Show("Information Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = bl.da.salesInfo();
                    return;
                }
            }

            else
                return;
        }
               

        private void owner_remove_employee_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Want to Update Your Personal Info?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                bl.DeletePersonInformation(int.Parse(emp_id_tb.Text));
                bl.DeleteLoginInfo(int.Parse(emp_id_tb.Text));

                MessageBox.Show("Person Deleted", "Information");
                dataGridView1.DataSource = bl.da.salesInfo();


              emp_id_tb.Text = emp_name_tb.Text = emp_add_tb.Text = emp_phone_tb.Text = emp_email_tb.Text = emp_nid_tb.Text = String.Empty;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manager mgr = new Manager();

            mgr.Show();

            this.Hide();
        }

        private void ManagerEmployeeInformation_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
    }

