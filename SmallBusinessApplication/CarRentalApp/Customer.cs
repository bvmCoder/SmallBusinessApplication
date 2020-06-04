using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using System.Data; 
using System.Data.SqlClient; 


namespace CarRentalApp
{
    class Customer
    {

        #region "Connection String Declaration"
      
        private string strConn = "Data Source=DESKTOP-VDQVKUL\\SQLEXPRESS;Initial Catalog=SmallBusinessDB;Integrated Security=True";
        #endregion


        private string m_IDNumber;
        private string m_Name;
        private string m_SSNumber;
        private string m_BirthDate;
        private int m_Age;
        private string m_Address;
        private string m_Phone;
        private string m_Email;

        //Private STATIC Data declaration:
        private static int m_Count = 0;

        public string IDNumber
        {
            get { return m_IDNumber; }
            set { m_IDNumber = value; }
        }
        public string Name
        {
            get { return m_Name; }
            set { m_Name = value; }
        }
        public string SSNumber
        {
            get { return m_SSNumber; }
            set { m_SSNumber = value; }
        }
        public string BirthDate
        {
            get { return m_BirthDate; }
            set
            {
                m_BirthDate = value;
                m_Age = CalculateAnyPersonAge(BirthDate);
            }
        }
        
        public int Age
        {
            get { return m_Age; }
        }

        public string Address
        {
            get { return m_Address; }
            set { m_Address = value; }
        }
        public string Phone
        {
            get { return m_Phone; }
            set { m_Phone = value; }
        }
        public string Email
        {
            get { return m_Email; }
            set { m_Email = value; }
        }
        
        public static int Count
        {
            get { return m_Count; }
            set { m_Count = value; }
        }


        public Customer()
        {
            m_IDNumber = "";
            m_Name = "";
            m_SSNumber = "";
            m_BirthDate = "00/00/0000";
            m_Age = 0;
            m_Address = "";
            m_Phone = "";
            m_Email = "";
          
            m_Count++;
        }


        public Customer(string IDNum, string strName, string strSSNum, string strBDate, string strAddress,
        string strPhone, string strEmail)
        {
            
            this.IDNumber = IDNum;
            this.Name = strName;
            this.SSNumber = strSSNum;
            this.BirthDate = strBDate;
            this.Address = strAddress;
            this.Phone = strPhone;
            this.Email = strEmail;

            m_Count++;
        }


        ~Customer()
        {
 
        }


        
        public void Print()
        {
            
            StreamWriter objPrinterFile = new StreamWriter("Network_Printer.txt", true);
          
            objPrinterFile.WriteLine("Customer Information ............");
            objPrinterFile.WriteLine("ID Number = {0}", m_IDNumber);
            objPrinterFile.WriteLine("Name = {0}", m_Name);
            objPrinterFile.WriteLine("Social Security Number = {0}", m_SSNumber);
            objPrinterFile.WriteLine(" Date of Birth = {0}", m_BirthDate);
            objPrinterFile.WriteLine("Age = {0}", m_Age);
            objPrinterFile.WriteLine("Address = {0}", m_Address);
            objPrinterFile.WriteLine("Phone Number = {0}", m_Phone);
            objPrinterFile.WriteLine("Phone Number = {0}", m_Email);
            objPrinterFile.WriteLine();
            objPrinterFile.WriteLine();
        
            objPrinterFile.Close();
        }
        private static int CalculateAnyPersonAge(string strBirthDate)
        {
           
            int age;
            
            DateTime objBirthDate = Convert.ToDateTime(strBirthDate);
          
            age = DateTime.Now.Year - objBirthDate.Year;
      
            if (DateTime.Now.DayOfYear < objBirthDate.DayOfYear)
                age = age - 1;
            return age;
        }

        public bool Load(string IDNumber)
        {
            bool found = false;
            
            SqlConnection objConn = new SqlConnection(strConn);
            
            try
            {
               
                objConn.Open();
                
                string strSQL = "SELECT * FROM Customer WHERE Customer_IDNumber = @Customer_IDNumber";
                
                SqlCommand objCmd = new SqlCommand(strSQL, objConn);

                objCmd.CommandType = CommandType.Text;
                
                objCmd.Parameters.Add("@Customer_IDNumber", SqlDbType.VarChar).Value = IDNumber;

               
                SqlDataReader objDR = objCmd.ExecuteReader();
                
                if (objDR.HasRows)
                {
                   
                    objDR.Read();
                    
                    this.IDNumber = objDR.GetString(0);
                    this.Name = objDR.GetString(1);
                    this.SSNumber = objDR.GetString(2);
                    this.BirthDate = objDR.GetString(3);
                   
                    this.Address = objDR.GetString(4);
                    this.Phone = objDR.GetString(5);
                    this.Email = objDR.GetString(6);
                   
                    found = true;
                }
               
                objDR.Close();
                objDR = null;
                objCmd.Dispose();
                objCmd = null;
                
                return found;
            }
            catch (System.Exception)
            {
               
                throw new System.Exception();
            }
            finally
            {
               
                objConn.Close();
                objConn.Dispose();
                objConn = null;
            }


        }

        public bool Insert()
        {
            
            bool found = false;
            
            SqlConnection objConn = new SqlConnection(strConn);
            
            try
            {
                
                objConn.Open();
                
                string strSQL;
                strSQL = "INSERT INTO Customer ( Customer_IDNumber,Customer_Name,";
                strSQL = strSQL + "Customer_SSNumber,Customer_BDate,Customer_Address,";
                strSQL = strSQL + "Customer_Phone,Customer_Email)";
                strSQL = strSQL + "VALUES(@Customer_IDNumber,";
                strSQL = strSQL + "@Customer_Name,@Customer_SSNumber,@Customer_BDate,";
                strSQL = strSQL + "@Customer_Address,@Customer_Phone,@Customer_Email)";
                
                SqlCommand objCmd = new SqlCommand(strSQL, objConn);
               
                objCmd.CommandType = CommandType.Text;
                
                objCmd.Parameters.Add("@Customer_IDNumber", SqlDbType.VarChar).Value = this.IDNumber;
                objCmd.Parameters.Add("@Customer_Name", SqlDbType.VarChar).Value = this.Name;
                objCmd.Parameters.Add("@Customer_SSNumber", SqlDbType.VarChar).Value = this.SSNumber;
                objCmd.Parameters.Add("@Customer_BDate", SqlDbType.VarChar).Value = this.BirthDate;
                objCmd.Parameters.Add("@Customer_Address", SqlDbType.VarChar).Value = this.Address;
                objCmd.Parameters.Add("@Customer_Phone", SqlDbType.VarChar).Value = this.Phone;
                objCmd.Parameters.Add("@Customer_Email", SqlDbType.VarChar).Value = this.Email;

                int intRecordsAffected = objCmd.ExecuteNonQuery();
               
                if (intRecordsAffected == 1)
                {
                   
                    found = true;
                }
                
                objCmd.Dispose();
                objCmd = null;
                
                return found;
            }
           
            catch (System.Exception)
            {
                
                throw new System.Exception();
            }
            finally
            {
                
                objConn.Close();
                objConn.Dispose();
                objConn = null;
            }
        }

        public bool Update()
        {
            
            bool found = false;
            
            SqlConnection objConn = new SqlConnection(strConn);
            
            try
            {
                
                objConn.Open();
               
                string strSQL;
                strSQL = "UPDATE Customer ";
                strSQL = strSQL + "SET Customer_Name=@Customer_Name,";
                strSQL = strSQL + "Customer_SSNumber=@Customer_SSNumber,";
                strSQL = strSQL + "Customer_BDate=@Customer_BDate,";
                strSQL = strSQL + "Customer_Address=@Customer_Address,";
                strSQL = strSQL + "Customer_Phone=@Customer_Phone,";
                strSQL = strSQL + "Customer_Email=@Customer_Email";
                strSQL = strSQL + " WHERE Customer_IDNumber=@Customer_IDNumber;";

                
                SqlCommand objCmd = new SqlCommand(strSQL, objConn);
                
                objCmd.CommandType = CommandType.Text;
              
                objCmd.Parameters.Add("@Customer_Name", SqlDbType.VarChar).Value = this.Name;
                objCmd.Parameters.Add("@Customer_SSNumber", SqlDbType.VarChar).Value = this.SSNumber;
                objCmd.Parameters.Add("@Customer_BDate", SqlDbType.VarChar).Value = this.BirthDate;
                objCmd.Parameters.Add("@Customer_Address", SqlDbType.VarChar).Value = this.Address;
                objCmd.Parameters.Add("@Customer_Phone", SqlDbType.VarChar).Value = this.Phone;
                objCmd.Parameters.Add("@Customer_Email", SqlDbType.VarChar).Value = this.Email;
                objCmd.Parameters.Add("@Customer_IDNumber", SqlDbType.VarChar).Value = this.IDNumber;

                
                int intRecordsAffected = objCmd.ExecuteNonQuery();
                
                if (intRecordsAffected == 1)
                {
                   
                    found = true;
                }
              
                objCmd.Dispose();
                objCmd = null;
              
                return found;
            }
            catch (System.Exception)
            {
                
                throw new System.Exception();
            }
            finally
            {
               
                objConn.Close();
                objConn.Dispose();
                objConn = null;
            }

        }

        public bool Delete(string IDNumber)
        {
            
            bool found = false;
           
            SqlConnection objConn = new SqlConnection(strConn);
            
            try
            {
                
                objConn.Open();
               
                string strSQL = "DELETE FROM Customer WHERE Customer_IDNumber = @Customer_IDNumber";
                
                SqlCommand objCmd = new SqlCommand(strSQL, objConn);
               
                objCmd.CommandType = CommandType.Text;
              
                objCmd.Parameters.Add("@Customer_IDNumber", SqlDbType.VarChar).Value = IDNumber;

                int intRecordsAffected = objCmd.ExecuteNonQuery();
               
                if (intRecordsAffected == 1)
                {
                   
                    found = true;
                }
              
                objCmd.Dispose();
                objCmd = null;
                
                return found;
            }

            catch (System.Exception)
            {
               
                throw new System.Exception();
            }
            finally
            {
                
                objConn.Close();
                objConn.Dispose();
                objConn = null;
            }

        }

    }
}
