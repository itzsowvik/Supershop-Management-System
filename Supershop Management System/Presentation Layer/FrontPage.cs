using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Supershop_Management_System.Business_Layer;
using Supershop_Management_System.Data_Access_Layer;

namespace Supershop_Management_System.Presentation_Layer
{
    public partial class FrontPage : Form
    {

        public static int nowId;
        BusinessLayer bl = new BusinessLayer();
        public FrontPage()
        {
            InitializeComponent();
        }

        private void FrontPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FrontPage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int id, password,parsedValue;

            if (!int.TryParse(shopid_textbox.Text, out parsedValue))
            {
                MessageBox.Show("ShopID is Number Only Field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                return;
            }

            else if (!int.TryParse(password_textbox.Text, out parsedValue))
            {
                MessageBox.Show("Password Field Must be Numarical", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                return;
            }      
            else
            {

                id = int.Parse(shopid_textbox.Text);
                password = int.Parse(password_textbox.Text);

                nowId = id;


                if (bl.LoginPerform(id, password))
                {
                    if (DataAccess.roleOfPerson == "manager")
                    {
                        Manager manager = new Manager();

                        manager.Show();
                        this.Hide();
                    }

                    if (DataAccess.roleOfPerson == "owner")
                    {
                        Owner owner = new Owner();

                        owner.Show();

                        this.Hide();
                    }

                    if (DataAccess.roleOfPerson == "salesman")
                    {
                        Employee emp = new Employee();

                        emp.Show();
                        this.Hide();
                    }
                }

                else
                {
                    MessageBox.Show("Wrong ID or Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

             
                  
                
            }


        }
    }

