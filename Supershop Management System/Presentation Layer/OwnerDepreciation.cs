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
    public partial class OwnerDepreciation : Form
    {
        BusinessLayer bl = new BusinessLayer();
        int propertyId = 1004;
        public OwnerDepreciation()
        {
            InitializeComponent();
        }

        private void OwnerDepreciation_Load(object sender, EventArgs e)
        {
            depreciation_dataGridView.DataSource = bl.DepreciationInfo();
        }

        public double accumulatedDepreciation, annualDepreciation, rate, monthlyDepreciation, bookvalue, depreciablecost;

        private void OwnerDepreciation_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dep_back_button_Click(object sender, EventArgs e)
        {
            OwnerBusinessInfo mgbi = new OwnerBusinessInfo();

            mgbi.Show();
            this.Hide();
        }

        private void dep_addproperty_button_Click(object sender, EventArgs e)
        {
            propertyId++;

            string proptype, propname;

            proptype = dep_proptype_tb.Text;

            propname = dep_propname_tb.Text;

            int price = Convert.ToInt32(dep_propprice_tb.Text);
            int salval = Convert.ToInt32(dep_salvageval_tb.Text);
            int usbYear = Convert.ToInt32(dep_usable_years_tb.Text);

            CalculateDepreciation(price, usbYear, salval);

            bl.InsertDepreciation(proptype, propname, propertyId, price, usbYear, accumulatedDepreciation, annualDepreciation, rate, monthlyDepreciation, bookvalue, salval, depreciablecost);

            MessageBox.Show("New Property Added", "Information");

            depreciation_dataGridView.DataSource = bl.DepreciationInfo();

            dep_proptype_tb.Text = dep_propname_tb.Text = dep_propprice_tb.Text = dep_salvageval_tb.Text = dep_usable_years_tb.Text = String.Empty;
        }

        public void CalculateDepreciation(int price, int usableYears, int salvageValue)
        {
            depreciablecost = Convert.ToDouble(price - salvageValue);

            rate = Convert.ToDouble(100 / usableYears);

            annualDepreciation = depreciablecost / usableYears;

            accumulatedDepreciation = 0;

            monthlyDepreciation = annualDepreciation / 12;

            bookvalue = depreciablecost - accumulatedDepreciation;

        }
    }
}
