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
    public partial class Owner : Form
    {
        BusinessLayer bl = new BusinessLayer();
        public Owner()
        {
            InitializeComponent();
        }

        private void owner_comp_info_button_Click(object sender, EventArgs e)
        {
            OwnerBusinessInfo bus = new OwnerBusinessInfo();

            this.Hide();
            bus.Show();
        }

        private void owner_add_product_button_Click(object sender, EventArgs e)
        {
            OwnerAddProduct owap = new OwnerAddProduct();

            owap.Show();
            this.Hide();
        }

        private void owner_add_emp_button_Click(object sender, EventArgs e)
        {
            owner_AddEmployee oae = new owner_AddEmployee();

            oae.Show();

            this.Hide();
        }

        private void owner_emp_info_button_Click(object sender, EventArgs e)
        {
            Owner_EmployeeInformaton oem = new Owner_EmployeeInformaton();

            oem.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrontPage fp = new FrontPage();

            fp.Show();

            this.Hide();
        }

        private void owner_profile_button_Click(object sender, EventArgs e)
        {
            OwnerInfoUpdate oif = new OwnerInfoUpdate();
            this.Hide();
            oif.Show();
        }

        private void Owner_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bl.SaleHistoryView();
        }

        private void Owner_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
