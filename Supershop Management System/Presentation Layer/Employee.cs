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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Supershop_Management_System.Presentation_Layer
{

    



    struct addeditem
    {
        public int productID;
        public int quantity;
    }


    public partial class Employee : Form
    {

        List<addeditem>items = new List<addeditem>();



        
        int CellClick_emp=0,price, lastPrice, quantity,check=0,Totalprice=0,dealPrice,selPrice;
        string procdType, PdfData = "Product Id" + "        " + "Product Name" + "        " + "Quantity" + "        " + "Price" + "\n";

       

        static int x = 3;


       
        

        BusinessLayer bl = new BusinessLayer();
        public Employee()
        {
            InitializeComponent();
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            FrontPage f = new FrontPage(); 
            this.Hide();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           FrontPage fp = new FrontPage();

            
            this.Hide();
            fp.Show();
        }

        private void emp_load_button_Click(object sender, EventArgs e)
        {
            emp_items_datagridview.DataSource = bl.ShowProduct();
            emp_searchitem_textbox.Text = String.Empty;
        }

        private void emp_update_personal_info_button_Click(object sender, EventArgs e)
        {
            Employee_Update_Info empui = new Employee_Update_Info();

            empui.ShowDialog();
            
        }

        private void emp_upd_personal_info_Click(object sender, EventArgs e)
        {
            Employee_Update_Info empui = new Employee_Update_Info();

            empui.ShowDialog();
        }

        private void emp_logout_Click(object sender, EventArgs e)
        {
            FrontPage f = new FrontPage();
            this.Hide();
            f.Show();
        }

        private void emp_sell_button_Click(object sender, EventArgs e)
        {
            x++;
            Random rand = new Random();
            int data = rand.Next(1000, 9999);

            string z = data + "Invoice " + x + ".pdf";
            
            Document doc = new Document(iTextSharp.text.PageSize.A4.Rotate());
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(z,FileMode.Create));
            doc.Open();
            
                double vat = Convert.ToDouble(Totalprice) * 0.15;

                double NetTotal =Convert.ToDouble(Totalprice) + vat;

                string Nettotaldata = "\n\n\n\nTotal = " + Totalprice.ToString() + "\n" + "Vat = " + vat.ToString() + "\n" +"--------------------------------\n"+ "Net Total = " + NetTotal.ToString() + "\n";

                PdfData += Nettotaldata;
            Paragraph paragraph = new Paragraph(PdfData);       
            doc.Add(paragraph);
            doc.Close();

            emp_total_sales_label.Text = "0";
            emp_vat_label.Text = "0";
            emp_net_total_label.Text = "0";
            price = 0;
            lastPrice = 0;
            quantity = 0;
            check = 0;
            Totalprice = 0;
            PdfData = "Product Id" + "      " + "Product Name" + "      " + "Quantity" + "      " + "Price" + "\n"; ;
            emp_added_items.Items.Clear();

            MessageBox.Show("Product Sold and Invoice Printed");
        }

        private void Employee_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void emp_rem_button_Click(object sender, EventArgs e)
        {
            emp_total_sales_label.Text = "0";
            emp_vat_label.Text = "0";
            emp_net_total_label.Text = "0";
            product_id_label.Text = productname_label.Text = quantity_textbox.Text = price_label.Text = string.Empty;

            price = 0;
            lastPrice = 0;
            quantity = 0;
            check = 0;
            Totalprice = 0;
            PdfData = "Product Id" + "      " + "Product Name" + "      " + "Quantity" + "      " + "Price" + "\n"; ;

            //list 

            foreach (addeditem item in items)
            {

                bl.retrieveItem(item.productID,item.quantity);

            }




            //list

            

            emp_added_items.Items.Clear();

            emp_items_datagridview.DataSource = bl.ShowProduct();

        }

        private void Employee_Load(object sender, EventArgs e)
        {
            emp_items_datagridview.DataSource = bl.ShowProduct();
        }

        private void emp_search_button_Click(object sender, EventArgs e)
        {
            if(bl.TextCheck(emp_searchitem_textbox.Text) && bl.EmptyCheck(emp_searchitem_textbox.Text))
            {
                string name = emp_searchitem_textbox.Text;
                if (bl.ShowSearchedProduct(name) == null)
                {
                    MessageBox.Show("Product Not Available", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    emp_items_datagridview.DataSource = bl.ShowSearchedProduct(name);
                }
            }



            
            
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            if (bl.NumberCheck(quantity_textbox.Text) && bl.EmptyCheck(quantity_textbox.Text))
            {
                string product_id, productname;

                product_id = product_id_label.Text;
                productname = productname_label.Text;


                quantity = int.Parse(quantity_textbox.Text);
                string messg = "Don't have enough ammount of " + productname + ".";

                if (quantity > check)
                {

                    MessageBox.Show(messg, "Important Message");
                    return;


                }

                quantity_textbox.Text = String.Empty;


                //list added

                addeditem xd = new addeditem();

                xd.productID = int.Parse(product_id);
                xd.quantity = quantity;

                items.Add(xd);






                //list added
                lastPrice = price * quantity;

                price_label.Text = lastPrice.ToString();

                Totalprice += lastPrice;

                emp_total_sales_label.Text = Totalprice.ToString();

                double vat = Convert.ToDouble(Totalprice) * 0.15;

                emp_vat_label.Text = vat.ToString();

                emp_net_total_label.Text = (Convert.ToDouble(Totalprice) + vat).ToString();



                int newQuantity = check - quantity;

                bool x = bl.UpdateProductInfo(productname, int.Parse(product_id), newQuantity, dealPrice, selPrice, procdType);


                var show = new ListViewItem(new[] { product_id, productname, quantity.ToString(), lastPrice.ToString() });

                string tempdata;

                tempdata = product_id + "               " + productname + "               " + quantity.ToString() + "               " + lastPrice.ToString() + "\n";


                PdfData += tempdata;

                emp_added_items.Items.Add(show);

                emp_items_datagridview.DataSource = bl.ShowProduct();

                string date = DateTime.Now.ToString();

                bl.AddSaleHistory(productname, quantity, price, lastPrice, date, int.Parse(product_id));
            }
                


        }

        private void emp_items_datagridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(emp_items_datagridview.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                emp_items_datagridview.CurrentRow.Selected = true;
                //emp_added_items.Items.Clear();


                CellClick_emp++;

                foreach (DataGridViewRow row in emp_items_datagridview.SelectedRows)
                {
                    //var item = emp_items_datagridview.Rows[e.RowIndex].Cells[1].Value;
                    //var item1 = emp_items_datagridview.Rows[e.RowIndex].Cells[0].Value;
                    //var item2 = 1;
                    //var item3 = Convert.ToInt32(emp_items_datagridview.Rows[e.RowIndex].Cells[4].Value);

                    ////item3 = CellClick_emp * item3;
                    //item2 = CellClick_emp * item2;

                    check = Convert.ToInt32(emp_items_datagridview.Rows[e.RowIndex].Cells[2].Value.ToString());

                   dealPrice = Convert.ToInt32(emp_items_datagridview.Rows[e.RowIndex].Cells[3].Value.ToString());

                   selPrice = Convert.ToInt32(emp_items_datagridview.Rows[e.RowIndex].Cells[4].Value.ToString());

                   procdType= emp_items_datagridview.Rows[e.RowIndex].Cells[5].Value.ToString();


                   product_id_label.Text = emp_items_datagridview.Rows[e.RowIndex].Cells[1].Value.ToString();

                    price_label.Text = emp_items_datagridview.Rows[e.RowIndex].Cells[4].Value.ToString();

                    productname_label.Text = emp_items_datagridview.Rows[e.RowIndex].Cells[0].Value.ToString();

                    quantity_textbox.Text = "1";

                    price = int.Parse(emp_items_datagridview.Rows[e.RowIndex].Cells[4].Value.ToString());

                }
       

            }
        }

        private void Calculate_button_Click(object sender, EventArgs e)
        {
            if(bl.NumberCheck(quantity_textbox.Text) && bl.EmptyCheck(quantity_textbox.Text))
            {
                quantity = int.Parse(quantity_textbox.Text);

                lastPrice = price * quantity;

                price_label.Text = lastPrice.ToString();
            }
       
           
        }
    }
}
