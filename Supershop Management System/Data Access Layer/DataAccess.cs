using System;
using System.Data;
using System.Data.SqlClient;

namespace Supershop_Management_System.Data_Access_Layer
{

    public class Person
    {
        public static int sidOfManager = 10006;
        public static int sidOfOwner = 2006;
        public static int sidOfSalesman = 3006;

        public string roleOfPerson;
        public int sid;
        public int password;
    }

    
    class UpadtePerson
    {
        //public  int salId ;
        public  int pass;
        public string Name;
        public string Address;
        public string Email;
        public int Nid;
        public int Phone;
    }
 








    class DataAccess
    {
        SqlConnection con;
        public  Person per;
        public UpadtePerson upPerson = new UpadtePerson();
       


        public static int currentUser;
        public static string roleOfPerson;


        public DataAccess()
        {

            con = new SqlConnection(@"Data Source=HP-PROBOOK\SQLEXPRESS;Initial Catalog=SuperShopDatabase;Integrated Security=True");

            if (con.State == ConnectionState.Closed)
            {

                con.Open();
            }

            per = new Person();

        }

        public UpadtePerson PersonupdatePage(int sid)
        {

          
            string query = string.Format("Select * from personInfo where sid={0}", sid);

            SqlCommand cmd = new SqlCommand(query,con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);
       
            upPerson.Name = Convert.ToString(dt.Rows[0][1]);

            upPerson.Phone = Convert.ToInt32(dt.Rows[0][2]);


            upPerson.Address = Convert.ToString(dt.Rows[0][3]);

            upPerson.Email = Convert.ToString(dt.Rows[0][4]);

            upPerson.Nid = Convert.ToInt32(dt.Rows[0][5]);



            //sales update object
    
            string query1 = string.Format("Select password from loginSSD where sid={0}", sid);


            SqlCommand cmd1 = new SqlCommand(query1, con);

            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);

            DataTable dt1 = new DataTable();

            da1.Fill(dt1);

            upPerson.pass = Convert.ToInt32(dt1.Rows[0][0]);

            return upPerson;



        }




       









        public void StatusUpdate(int status, int sid)
        {
            // con.Open();
            string query = string.Format("UPDATE loginSSD SET status={0} where sid={1} ", status, sid);
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
        }


        public void LogoutDataAccess(int status, int sid)
        {

            StatusUpdate(status, sid);


        }


        public bool LoginDataAccess(int sid, int password)
        {
            
            SqlCommand check_User_ID = new SqlCommand("SELECT * FROM loginSSD WHERE ([sid] = @sid)", con);
            check_User_ID.Parameters.AddWithValue("@sid", sid);
            SqlDataReader reader = check_User_ID.ExecuteReader();

            if(reader.HasRows)
            {
                reader.Close();

                String query = String.Format("Select sid,password,role from loginSSD where sid = {0}", sid);

                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataAdapter dataadapter = new SqlDataAdapter(cmd);

                DataTable datatable = new DataTable();

                dataadapter.Fill(datatable);

                int pass = Convert.ToInt32(datatable.Rows[0][1]);
                string role = Convert.ToString(datatable.Rows[0][2]);
                if (pass == password)
                {
                    
                    StatusUpdate(1, sid);

                    DataAccess.currentUser = sid;
                    DataAccess.roleOfPerson = role;

                    
                    return true;

                }

               

            }
            reader.Close();
            return false;

            
        }



        //1

        public Person InsertloginSSD(string roleOfPerson)
        {
            Random rand = new Random();
            per.password = rand.Next(100000, 999999);


            if (roleOfPerson == "manager")
            {
                Person.sidOfManager++;
                per.sid = Person.sidOfManager;
                per.roleOfPerson = roleOfPerson;
            }
            else if (roleOfPerson == "owner")
            {
                Person.sidOfOwner++;
                per.sid = Person.sidOfOwner;
                per.roleOfPerson = roleOfPerson;
            }
            else
            {
                Person.sidOfSalesman++;
                per.sid = Person.sidOfSalesman;
                per.roleOfPerson = roleOfPerson;

            }


            int status = 0;

            //con.Open();
            string query = string.Format("INSERT INTO loginSSD(sid,password,status,role) VALUES({0},{1},{2},'{3}')", per.sid, per.password, status, roleOfPerson);

            SqlCommand cmd = new SqlCommand(query, con);
            int rows = -1;

            rows = cmd.ExecuteNonQuery();



            if (rows >= 0)
            {

                return per;
            }

            per.roleOfPerson = "No user created";

            return per;

        }




        //2  

        public bool InsertproductSSD(string productName, int productID, int quantity, int dealerPrice, int sellPrice, string productType)
        {
            //con.Open();
            string query = string.Format("INSERT INTO productSSD(productName,productID,quantity,dealerPrice,sellPrice,productType) VALUES('{0}',{1},{2},{3},{4},'{5}')", productName, productID, quantity, dealerPrice, sellPrice, productType);

            SqlCommand cmd = new SqlCommand(query, con);
            int rows = -1;

            rows = cmd.ExecuteNonQuery();


            if (rows >= 0)
            {

                return true;
            }


            return false;

        }



        //3 

        public bool InsertpersonInfo(int sid, string name, int phone, string address, string email, int nid)
        {
            //con.Open();
            string query = string.Format("INSERT INTO personInfo(sid,name,phone,address,email,nid) VALUES({0},'{1}',{2},'{3}','{4}',{5})", sid, name, phone, address, email, nid);

            SqlCommand cmd = new SqlCommand(query, con);
            int rows = -1;

            rows = cmd.ExecuteNonQuery();


            if (rows >= 0)
            {

                return true;
            }


            return false;

        }


        //4 

        public bool InsertSaleHistory(string pName, int quantity, int price, int totalPrice, string saledate,int pid)
        {
            //con.Open();
            string query = string.Format("INSERT INTO newSaleHistory(pName,quantity,price,totalPrice,saledate,pid) VALUES('{0}',{1},{2},{3},'{4}',{5})", pName,quantity, price, totalPrice, saledate ,pid);

            SqlCommand cmd = new SqlCommand(query, con);
            int rows = -1;

            rows = cmd.ExecuteNonQuery();


            if (rows >= 0)
            {

                return true;
            }


            return false;

        }


        //5




        public bool InsertempActivity(int sid, double whour, string logintime, string logouttime, int salary, int commision)
        {
            //con.Open();
            string query = string.Format("INSERT INTO empActivity(sid,whour,logintime,logouttime,salary,commision) VALUES({0},{1},'{2}','{3}',{4},{5})", sid, whour, logintime, logouttime, salary, commision);

            SqlCommand cmd = new SqlCommand(query, con);
            int rows = -1;

            rows = cmd.ExecuteNonQuery();


            if (rows >= 0)
            {

                return true;
            }


            return false;

        }





        //6 

        public bool Insertdepreciation(string propertyType, string propertyName, int propertyID, int price, int usableYears, int accumulatedDepreciation, int annualDepreciation, double rate)
        {
            //con.Open();
            string query = string.Format("INSERT INTO depreciation(  propertyType,  propertyName,  propertyID,  price,  usableYears, accumulatedDepreciation,annualDepreciation, rate) VALUES('{0}','{1}',{2},{3},{4},{5},{6},{7})", propertyType, propertyName, propertyID, price, usableYears, accumulatedDepreciation, annualDepreciation, rate);

            SqlCommand cmd = new SqlCommand(query, con);
            int rows = -1;

            rows = cmd.ExecuteNonQuery();


            if (rows >= 0)
            {

                return true;
            }


            return false;

        }


        public void retrieveItem(int productID,int addedquantity)
        {

             int quantity;

            string query = string.Format("select quantity from productSSD where productID={0}", productID);


            SqlCommand cmd = new SqlCommand(query, con);

            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            quantity =Convert.ToInt32(dt.Rows[0][0].ToString());

            quantity += addedquantity;

            string query1 = string.Format("UPDATE productSSD SET quantity={1} WHERE productID={0} ",productID,quantity);


            SqlCommand cmd1 = new SqlCommand(query1, con);

            cmd1.ExecuteNonQuery();



        }




        //1.1
        public bool UpdateproductSSD(string productName, int productID, int quantity, int dealerPrice, int sellPrice, string productType)
        {
            
            string query = string.Format("UPDATE productSSD SET productName='{0}',productID={1},quantity={2},dealerPrice={3},sellPrice={4},productType='{5}' WHERE productID={1} ", productName, productID, quantity, dealerPrice, sellPrice, productType);
            SqlCommand cmd = new SqlCommand(query, con);

            int rows = -1;
            rows = cmd.ExecuteNonQuery();

            if (rows >= 0)
            {
                return true;
            }

            return false;

        }

        //1.2

        public bool UpdateloginSSD(int sid, int password, String role)
        {

            string query = string.Format("UPDATE loginSSD SET password={0},role='{1}' WHERE sid={2} ", password, role, sid);
            SqlCommand cmd = new SqlCommand(query, con);

            int rows = -1;
            rows = cmd.ExecuteNonQuery();

            if (rows >= 0)
            {
                return true;
            }

            return false;

        }






        //1.3


        public bool UpdateSaleHistory(string pName, int saleId, int quantity, int price, int totalPrice, string saledate, int pid)
        {
         
            string query = string.Format("UPDATE newSaleHistory SET pName='{0}',saleId={1},quantity={2},Price={3},totalPrice={4},saledate='{5}',pid={6} WHERE saleId={1} ", pName, saleId, quantity, price, totalPrice, saledate, pid);
            SqlCommand cmd = new SqlCommand(query, con);

            int rows = -1;
            rows = cmd.ExecuteNonQuery();

            if (rows >= 0)
            {
                return true;
            }

            return false;

        }


        //1.4



        public bool UpdateempActivity(int sid, double whour, string logintime, string logouttime, int salary, int commision)
        {
            
            string query = string.Format("UPDATE empActivity SET sid={0},whour={1},logintime='{2}',logouttime='{3}',salary='{4}',commision={5} WHERE sid={0} ", sid, whour, logintime, logouttime, salary, commision);
            SqlCommand cmd = new SqlCommand(query, con);

            int rows = -1;
            rows = cmd.ExecuteNonQuery();

            if (rows >= 0)
            {
                return true;
            }

            return false;

        }

        //1.5

        public bool Updatedepreciation(string propertyType, string propertyName, int propertyID, int price, int usableYears, int accumulatedDepreciation, int annualDepreciation, double rate)
        {
            //con.Open();
            string query = string.Format("UPDATE depreciation SET propertyType='{0}', propertyName='{1}', propertyID={2}, price={3}, usableYears={4}, accumulatedDepreciation={5},annualDepreciation={6},rate={7} WHERE propertyID={2} ", propertyType, propertyName, propertyID, price, usableYears, accumulatedDepreciation, annualDepreciation, rate);
            SqlCommand cmd = new SqlCommand(query, con);

            int rows = -1;
            rows = cmd.ExecuteNonQuery();

            if (rows >= 0)
            {
                return true;
            }

            return false;

        }


        //1.6



        public bool UpdatepersonInfo(int sid, string name, int phone, string address, string email, int nid)
        {
            
            string query = string.Format("UPDATE personInfo SET sid={0},name='{1}',phone={2},address='{3}',email='{4}',nid={5} WHERE sid={0} ", sid, name, phone, address, email, nid);
            SqlCommand cmd = new SqlCommand(query, con);

            int rows = -1;
            rows = cmd.ExecuteNonQuery();

            if (rows >= 0)
            {
                return true;
            }

            return false;

        }









        //2.1 
        public bool DeleteloginSSD(int sid)
        {

            string query = string.Format("DELETE FROM loginSSD WHERE sid={0}", sid);
            SqlCommand cmd = new SqlCommand(query, con);
            int rows = -1;
            rows = cmd.ExecuteNonQuery();

            if (rows >= 0)
            {
                return true;
            }

            return false;
        }




        //2.2 


        public bool DeleteproductSSD(string productName)
        {

            string query = string.Format("DELETE FROM productSSD WHERE productName='{0}'", productName);
            SqlCommand cmd = new SqlCommand(query, con);
            int rows = -1;
            rows = cmd.ExecuteNonQuery();

            if (rows >= 0)
            {
                return true;
            }

            return false;
        }

        //2.3 



        public bool DeleteSaleHistory(int saleId)
        {

            string query = string.Format("DELETE FROM newSaleHistory WHERE saleId={0}", saleId);
            SqlCommand cmd = new SqlCommand(query, con);
            int rows = -1;
            rows = cmd.ExecuteNonQuery();

            if (rows >= 0)
            {
                return true;
            }

            return false;
        }

        //2.4 

        public bool DeleteempActivity(int sid)
        {

            string query = string.Format("DELETE FROM empActivity WHERE sid={0}", sid);
            SqlCommand cmd = new SqlCommand(query, con);
            int rows = -1;
            rows = cmd.ExecuteNonQuery();

            if (rows >= 0)
            {
                return true;
            }

            return false;
        }


        //2.5
        public bool Deletedepreciation(int propertyID)
        {

            string query = string.Format("DELETE FROM depreciation WHERE propertyID={0}", propertyID);
            SqlCommand cmd = new SqlCommand(query, con);
            int rows = -1;
            rows = cmd.ExecuteNonQuery();

            if (rows >= 0)
            {
                return true;
            }

            return false;
        }








        //2.6

        public bool DeletepersonInfo(int sid)
        {
            string query = string.Format("DELETE FROM personInfo WHERE sid={0}", sid);
            SqlCommand cmd = new SqlCommand(query, con);
            int rows = -1;
            rows = cmd.ExecuteNonQuery();

            if (rows >= 0)
            {
                return true;
            }

            return false;
        }



        public DataTable ProductInfo()
        {
            string query = String.Format("Select * from productSSD");

            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }

        public DataTable salesInfo()
        {
            string query1 = String.Format("Select p.sid,p.name,p.phone,p.address,p.email,p.nid from loginSSD l ,personInfo p where l.sid=p.sid and l.role='salesman'");

            SqlCommand cmd1 = new SqlCommand(query1, con);

            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);

            DataTable dt1 = new DataTable();

            da1.Fill(dt1);

            return dt1;
        }

        public DataTable empsInfo()
        {
            string query1 = String.Format("Select p.sid,p.name,p.phone,p.address,p.email,p.nid from loginSSD l ,personInfo p where l.sid=p.sid and l.role<>'owner'");

            SqlCommand cmd1 = new SqlCommand(query1, con);

            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);

            DataTable dt1 = new DataTable();

            da1.Fill(dt1);

            return dt1;
        }





        public  DataTable ProductSearch(String name)
        {
            string query = String.Format("Select * from productSSD where productName = '{0}'", name);

            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }


        public DataTable Productinfo(int productID)
        {
            string query = String.Format("Select * from productSSD where productID = {0}", productID);

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }


        public DataTable Products()
        {
            string query = String.Format("Select * from productSSD");

            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }


        public DataTable EmployeeSearch(int sid)
        {
            string query = String.Format("Select * from personInfo where sid = {0}", sid);

            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }



        public bool InsertDepreciation(string proptype, string propname, int propID, int price, int usbYear, double accDep, double annDep, double rate, double monDep, double bookval, int salval, double depreciableCost)
        {


            string query1 = String.Format("select lastid from depreciation where propertyid = 1001");

            SqlCommand cmd1 = new SqlCommand(query1, con);

            SqlDataAdapter da = new SqlDataAdapter(cmd1);

            DataTable dt = new DataTable();

            da.Fill(dt);

            propID = int.Parse(dt.Rows[0][0].ToString());

            propID++;


            
            string query = string.Format("INSERT INTO depreciation(propertyType,propertyName,propertyID,price,usableYears,accumulatedDepreciation,annualDepreciation,rate,monthlyDepreciation,bookvalue,salvagevalue,depreciablecost) VALUES('{0}','{1}',{2},{3},{4},{5},{6},{7},{8},{9},{10},{11})", proptype, propname, propID, price, usbYear, accDep, annDep, rate, monDep, bookval, salval, depreciableCost);

            SqlCommand cmd = new SqlCommand(query, con);
            int rows = -1;

            rows = cmd.ExecuteNonQuery();


            string query2 = String.Format("UPDATE  depreciation set lastid = {0} where propertyid = 1001", propID);

            SqlCommand cmd2 = new SqlCommand(query2, con);

            cmd2.ExecuteNonQuery();
           


            if (rows >= 0)
            {
               

                return true;

            }


            return false;
        }

        public DataTable DepereciationInfo()
        {
            string query = String.Format("Select * from depreciation");

            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }


        public int Rowcounter()
        {
            
            string query = String.Format("SELECT COUNT(*) FROM productSSD");
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            return int.Parse(dt.Rows[0][0].ToString());
            
        }


        public int getsaleinfo(int pid)
        {

           int  totalquantity=0;

            string query = String.Format("Select quantity from newSaleHistory where pid={0}",pid);

            SqlCommand cmd = new SqlCommand(query, con);
            //int rows = cmd.ExecuteNonQuery();



            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

           



            string query1 = String.Format("SELECT COUNT(*) FROM newSaleHistory where pid={0}", pid);

            SqlCommand cmd1 = new SqlCommand(query1, con);

            DataTable dt1 = new DataTable();

            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);

            da1.Fill(dt1);

            int x = int.Parse(dt1.Rows[0][0].ToString());

            for (int i = 0; i<x; i++)
            {
                int quantity = int.Parse(dt.Rows[i][0].ToString());

                totalquantity += quantity;

            }

            return totalquantity;



           
        }







        public DataTable ProductView()
        {
            string query = String.Format("Select * from productSSD");

            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }

        public DataTable SaleHistoryView()
        {
            String query = String.Format("Select * from newSaleHistory");
            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;

        }


    }
}



