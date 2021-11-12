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
    public partial class ManagerBusinessInformation : Form
    {
        int totalProfit;
        BusinessLayer bl = new BusinessLayer();
        public ManagerBusinessInformation()
        {
            InitializeComponent();
        }

        private void managerDepreciation_Button_Click(object sender, EventArgs e)
        {
            ManagerDepreciation mgr = new ManagerDepreciation();

            mgr.Show();
            this.Hide();
        }

        void calculatetotalsale()
        {
            int x = 0;
            DataTable ab = bl.Products();
            int productid = 10000;



            x = bl.getRows();







            for (int i = 0; i < x; i++)
            {

                productid++;

                DataTable pd = bl.Productinfo(productid);

                int salequyantity = bl.getsaleinfo(productid);

                int unitsale = int.Parse(pd.Rows[0][4].ToString()) - int.Parse(pd.Rows[0][3].ToString());
                string product = pd.Rows[0][0].ToString();

                int profit = unitsale * salequyantity;

                totalProfit += profit;



                var show = new ListViewItem(new[] { product, salequyantity.ToString(), unitsale.ToString(), profit.ToString() });
                businessInfo_Listview.Items.Add(show);

            }







        }


        private void ManagerBusinessInformation_Load(object sender, EventArgs e)
        {

            calculatetotalsale();

            profit_label.Text = totalProfit.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manager man = new Manager();

            man.Show();

            this.Hide();
        }

        private void ManagerBusinessInformation_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
