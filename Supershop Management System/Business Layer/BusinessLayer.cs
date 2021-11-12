using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Supershop_Management_System.Data_Access_Layer;

namespace Supershop_Management_System.Business_Layer
{
    class BusinessLayer
    {
         public DataAccess da = new DataAccess();
        public bool LoginPerform(int sid, int password)
        {
            if(da.LoginDataAccess(sid, password))
            {
                return true;
            }

            return false;
        }

        public void LogoutPerform(int status, int sid)
        {
            da.LogoutDataAccess(status, sid);
        }

       /*public Person AddLoginInfo(string roleOfPerson)
        {
           if(da.InsertloginSSD(roleOfPerson))                     //Here is a Problem
            {
                return true;
            }
        }*/

        public bool AddProduct(string productName, int productID, int quantity, int dealerPrice, int sellPrice, string productType)
        {
            if(da.InsertproductSSD(productName,productID,quantity,dealerPrice,sellPrice,productType))
            {
                return true;
            }

            return false;
        }

        public bool AddPerson(int sid, string name, int phone, string address, string email, int nid)
        {
            if(da.InsertpersonInfo(sid,name, phone, address, email, nid))
            {
                return true;
            }

            return false;
        }

        //added item 

        public void retrieveItem(int productID, int addedquantity)
        {
            da.retrieveItem(productID,addedquantity);

        }

        public bool AddSaleHistory(string pName, int quantity, int price, int totalPrice, string saledate,int pid)
        {
            if(da.InsertSaleHistory(pName, quantity, price, totalPrice, saledate, pid))
            {
                return true;
            }

            return false;
        }

        public bool AddEmployeeActivity(int sid, double whour, string logintime, string logouttime, int salary, int commision)
        {
            if(da.InsertempActivity(sid, whour, logintime, logouttime, salary, commision))
            {
                return true;
            }

            return false;
        }

        public bool AddDepreciation(string propertyType, string propertyName, int propertyID, int price, int usableYears, int accumulatedDepreciation, int annualDepreciation, double rate)
        {
            if(da.Insertdepreciation(propertyType, propertyName, propertyID, price, usableYears, accumulatedDepreciation, annualDepreciation, rate))
            {
                return true;
            }

            return false;
        }

        public bool UpdateProductInfo(string productName, int productID, int quantity, int dealerPrice, int sellPrice, string productType)
        {
            if(da.UpdateproductSSD(productName, productID, quantity, dealerPrice,sellPrice,productType))
            {
                return true;
            }

            return false;
        }

        public bool UpdateLoginInfo(int sid, int password, String role) //Why Password is String here?
        {
            if(da.UpdateloginSSD(sid, password, role))
            {
                return true;
            }

            return false;
        }

        public bool UpdateSaleHistoryInfo(string pName, int saleId, int quantity, int price, int totalPrice, string saledate, int pid)
        {
            if (da.UpdateSaleHistory(pName,  saleId,  quantity,  price,  totalPrice,  saledate,  pid))
            {
                return true;
            }

            return false;
        }

        public bool UpdateEmployeeActivity(int sid, double whour, string logintime, string logouttime, int salary, int commision)
        {
            if(da.UpdateempActivity(sid, whour,logintime,logouttime, salary, commision))
            {
                return true;
            }

            return false;
        }

        public bool UpdateDepreciationValue(string propertyType, string propertyName, int propertyID, int price, int usableYears, int accumulatedDepreciation, int annualDepreciation, double rate)
        {
            if(da.Updatedepreciation(propertyType, propertyName, propertyID, price, usableYears, accumulatedDepreciation, annualDepreciation, rate))
            {
                return true;
            }

            return false;
        }

        public bool UpdatePersonInfo(int sid, string name, int phone, string address, string email, int nid)
        {
            if(da.UpdatepersonInfo(sid, name, phone, address, email, nid))
            {
                return true;
            }

            return false;
        }

        public bool DeleteLoginInfo(int sid)
        {
            if(da.DeleteloginSSD(sid))
            {
                return true;
            }

            return false;
        }

        public bool DeleteProductInfo(string productName)
        {
            if (da.DeleteproductSSD(productName))
            {
                return true;
            }

            return false;
        }

        public bool DeleteSaleInfo(int productId)
        {
            if (da.DeleteloginSSD(productId))
            {
                return true;
            }

            return false;
        }

        public bool DeleteEmployeeActivity(int sid)
        {
            if(da.DeleteempActivity(sid))
            {
                return true;
            }

            return false;
        }

        public bool DeleteDepreciationInfo(int propertyID)
        {
            if(da.Deletedepreciation(propertyID))
            {
                return true;
            }

            return false;
        }

        public bool DeletePersonInformation(int sid)
        {
            if(da.DeletepersonInfo(sid))
            {
                return true;
            }

            return false;
        }

        public DataTable ShowProduct()
        {
            return da.ProductInfo();
        }

        public DataTable ShowSearchedProduct(string name)
        {
            return da.ProductSearch(name);
        }

        public DataTable salesInfo()
        {
            return da.salesInfo();
        }

        public DataTable empsInfo()
        {
            return da.empsInfo();
        }



        public UpadtePerson PersonUpdatePage(int sid)

        {
            return da.PersonupdatePage(sid);
        }

       public DataTable EmployeeSearch(int sid)
        {
            return da.EmployeeSearch(sid);
        }

        public Person InsertloginSSD(string roleOfPerson)
        {
            return da.InsertloginSSD(roleOfPerson);
        }

       public bool InsertDepreciation(string proptype, string propname, int propID, int price, int usbYear, double accDep, double annDep, double rate, double monDep, double bookval, int salval, double depreciableCost)
        {
            if(da.InsertDepreciation( proptype,  propname,  propID,  price,  usbYear,  accDep,  annDep,  rate,  monDep,  bookval,  salval,  depreciableCost))
            {
                return true;
            }

            return false;
        }

        public DataTable DepreciationInfo()
        {
            return da.DepereciationInfo();
        }

        public DataTable ProductView()
        {
            return da.ProductView();
        }

        public DataTable Productinfo(int productID)
        {


            return da.Productinfo(productID);
        }



        public int getsaleinfo(int pid)
        {

            return da.getsaleinfo(pid);

        }

        public DataTable Products()
        {

            return da.Products();

        }

        public int getRows()
        {
            return da.Rowcounter();
        }



        public bool TextCheck(String text)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("This textbox accepts only alphabetical characters", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                //textBox1.Text.Remove(textBox1.Text.Length - 1);

                return false;
            }

            return true;
        }

        public bool NumberCheck(String text)
        {
            int parsedValue;

            if (!int.TryParse(text, out parsedValue))
            {
                MessageBox.Show("This textbox accepts only Numerical characters", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                return false;
            }

            return true;
        }

        public bool EmptyCheck(String text)
        {
            if(text == String.Empty)
            {
                MessageBox.Show("TextField can not be Empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                return false;
            }

            return true;
        }


        public DataTable SaleHistoryView()
        {
            return da.SaleHistoryView();
        }


    }
}
