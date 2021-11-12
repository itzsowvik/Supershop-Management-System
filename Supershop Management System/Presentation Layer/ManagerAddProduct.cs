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
    public partial class ManagerAddProduct : Form
    {
        BusinessLayer bl = new BusinessLayer();
        public ManagerAddProduct()
        {
            InitializeComponent();
        }

        private void search_button_Click(object sender, EventArgs e)
        {

            DataTable dt = bl.ShowSearchedProduct(prodname_textbox.Text);
            addProdName_tb.Text = dt.Rows[0][0].ToString();
            product_id_textbox.Text = dt.Rows[0][1].ToString();
            quantity_textbox.Text = dt.Rows[0][2].ToString();
            dealerprice_textbox.Text = dt.Rows[0][3].ToString();
            sellprice_textbox.Text = dt.Rows[0][4].ToString();
            productType_textbox.Text = dt.Rows[0][5].ToString();
            additem_dataGridView.DataSource = dt;
        }

        private void remove_item_Click(object sender, EventArgs e)
        {
            bl.DeleteProductInfo(prodname_textbox.Text);
            additem_dataGridView.DataSource = bl.ProductView();

            addProdName_tb.Text = product_id_textbox.Text = quantity_textbox.Text = dealerprice_textbox.Text = sellprice_textbox.Text = productType_textbox.Text = String.Empty;
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            if (bl.TextCheck(addProdName_tb.Text) && bl.TextCheck(productType_textbox.Text) && bl.NumberCheck(product_id_textbox.Text) && bl.NumberCheck(quantity_textbox.Text) && bl.NumberCheck(dealerprice_textbox.Text) && bl.NumberCheck(sellprice_textbox.Text) && bl.EmptyCheck(addProdName_tb.Text) && bl.EmptyCheck(product_id_textbox.Text) && bl.EmptyCheck(quantity_textbox.Text) && bl.EmptyCheck(dealerprice_textbox.Text) && bl.EmptyCheck(sellprice_textbox.Text) && bl.EmptyCheck(productType_textbox.Text))
            {
                bl.AddProduct(addProdName_tb.Text, int.Parse(product_id_textbox.Text), int.Parse(quantity_textbox.Text), int.Parse(dealerprice_textbox.Text), int.Parse(sellprice_textbox.Text), productType_textbox.Text);

                MessageBox.Show("Item Added");

                additem_dataGridView.DataSource = bl.ProductView();
                addProdName_tb.Text = product_id_textbox.Text = quantity_textbox.Text = dealerprice_textbox.Text = sellprice_textbox.Text = productType_textbox.Text = String.Empty;
            }
               
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            if (bl.TextCheck(addProdName_tb.Text) && bl.TextCheck(productType_textbox.Text) && bl.NumberCheck(product_id_textbox.Text) && bl.NumberCheck(quantity_textbox.Text) && bl.NumberCheck(dealerprice_textbox.Text) && bl.NumberCheck(sellprice_textbox.Text) && bl.EmptyCheck(addProdName_tb.Text) && bl.EmptyCheck(product_id_textbox.Text) && bl.EmptyCheck(quantity_textbox.Text) && bl.EmptyCheck(dealerprice_textbox.Text) && bl.EmptyCheck(sellprice_textbox.Text) && bl.EmptyCheck(productType_textbox.Text))
            {
                bl.UpdateProductInfo(addProdName_tb.Text, int.Parse(product_id_textbox.Text), int.Parse(quantity_textbox.Text), int.Parse(dealerprice_textbox.Text), int.Parse(sellprice_textbox.Text), productType_textbox.Text);
                MessageBox.Show("Product Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                additem_dataGridView.DataSource = bl.ProductView();
                addProdName_tb.Text = product_id_textbox.Text = quantity_textbox.Text = dealerprice_textbox.Text = sellprice_textbox.Text = productType_textbox.Text = String.Empty;
            }
               
        }

        private void button1_Click(object sender, EventArgs e)
        {
            additem_dataGridView.DataSource = bl.ProductView();
        }

        private void ManagerAddProduct_Load(object sender, EventArgs e)
        {
            additem_dataGridView.DataSource = bl.ProductView();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Manager mgr = new Manager();

            mgr.Show();

            this.Hide();
        }

        private void ManagerAddProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
