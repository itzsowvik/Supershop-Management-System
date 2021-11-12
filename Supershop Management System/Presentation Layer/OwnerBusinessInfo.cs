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
    public partial class OwnerBusinessInfo : Form
    {
        int totalProfit;
        public OwnerBusinessInfo()
        {
            InitializeComponent();

 
        }

        BusinessLayer bl = new BusinessLayer();



        void calculatetotalsale()
        {
            int x=0;
            DataTable ab = bl.Products();
            int productid = 10000;



            x = bl.getRows();
                
            

            



            for(int i=0;i<x;i++)
            {

                productid++;

                DataTable pd= bl.Productinfo(productid);

                int salequyantity = bl.getsaleinfo(productid);

                int unitsale = int.Parse(pd.Rows[0][4].ToString()) - int.Parse(pd.Rows[0][3].ToString());
                string product = pd.Rows[0][0].ToString();

                int profit = unitsale * salequyantity;

                totalProfit += profit;

                

                var show = new ListViewItem(new[] { product, salequyantity.ToString(), unitsale.ToString(), profit.ToString() });
                businessInfo_Listview.Items.Add(show);

            }


           




        }



        private void OwnerBusinessInfo_Load(object sender, EventArgs e)
        {
            calculatetotalsale();

            profit_label.Text = totalProfit.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Owner own = new Owner();

            own.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OwnerDepreciation dep = new OwnerDepreciation();

            dep.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void profit_label_Click(object sender, EventArgs e)
        {

        }

        private void businessInfo_Listview_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OwnerBusinessInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
