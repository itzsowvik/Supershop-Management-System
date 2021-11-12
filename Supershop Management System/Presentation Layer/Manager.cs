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
    public partial class Manager : Form
    {
        BusinessLayer bl = new BusinessLayer();
        public Manager()
        {
            InitializeComponent();
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bl.SaleHistoryView();
        }

        private void manager_profile_button_Click(object sender, EventArgs e)
        {
            manager_emp_update_info mgf = new manager_emp_update_info();
            mgf.Show();
            this.Hide();
            
        }

        private void Manager_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void owner_salesman_info_button_Click(object sender, EventArgs e)
        {
            ManagerEmployeeInformation mei = new ManagerEmployeeInformation();
            this.Hide();
            mei.Show();


        }

        private void owner_add_sm_button_Click(object sender, EventArgs e)
        {
            ManagerAddEmployee m = new ManagerAddEmployee();
            this.Hide();
            m.Show();
        }

        private void owner_comp_info_button_Click(object sender, EventArgs e)
        {
            ManagerBusinessInformation bs = new ManagerBusinessInformation();

            bs.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrontPage fp = new FrontPage();

            fp.Show();

            this.Hide();
        }

        private void manager_add_product_Click(object sender, EventArgs e)
        {
            ManagerAddProduct mga = new ManagerAddProduct();

            mga.Show();

            this.Hide();
        }
    }
}
