using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace CarRentalApp
{
    class CustomerList
    {

        #region "Private Data Declarations"

        private const int SIZE = 10;
        private Customer[] m_arrCustomerList;

        #endregion


        #region "Properties Declarations"

        #endregion

        #region "Constructor Methods Declarations"

        public CustomerList()
        {
            m_arrCustomerList = new Customer[SIZE];
        }

        ~CustomerList()
        {
            
        }
        #endregion

        #region "Regular Methods"

        public Customer Search(string ID)
        {
          
            for (int i = 0; i < SIZE; i++)
            {
                
                if (m_arrCustomerList[i] != null)
                {
                    
                    if (m_arrCustomerList[i].IDNumber == ID)
                       
                        return m_arrCustomerList[i];
                }
            }
            
            return null;
        }


        public bool Add(Customer objCustomer)
        {
           
            for (int i = 0; i < SIZE; i++)
            {
               
                if (m_arrCustomerList[i] == null)
                {
                   
                    m_arrCustomerList[i] = objCustomer;
                   
                    return true;
                }
            }
            return false;
        }

       
        public bool Add(string idNum, string name, string SSNum, string bDate, string address, string phone,
        string email)
        {
           
            Customer objCustomer = new Customer();
            
            objCustomer.IDNumber = idNum;
            objCustomer.Name = name;
            objCustomer.SSNumber = SSNum;
            objCustomer.BirthDate = bDate;
            objCustomer.Address = address;
            objCustomer.Phone = phone;
            objCustomer.Email = email;
            
            for (int i = 0; i < SIZE; i++)
            {
               
                if (m_arrCustomerList[i] == null)
                {
                    
                    m_arrCustomerList[i] = objCustomer;
                   
                    return true;
                }
            }
            return false; 
        }


        public bool Edit(Customer objCustomer)
        {
            
            for (int i = 0; i < SIZE; i++)
            {
                
                if (m_arrCustomerList[i] != null)
                {
                    
                    if (m_arrCustomerList[i].IDNumber == objCustomer.IDNumber)
                    {
                       
                        m_arrCustomerList[i].Name = objCustomer.Name;
                        m_arrCustomerList[i].SSNumber = objCustomer.SSNumber;
                        m_arrCustomerList[i].BirthDate = objCustomer.BirthDate;
                        m_arrCustomerList[i].Address = objCustomer.Address;
                        m_arrCustomerList[i].Phone = objCustomer.Phone;
                        m_arrCustomerList[i].Email = objCustomer.Email;
                        
                        return true;
                    }
                }
            }
            
            return false;
        }


     
        public bool Edit(string idNum, string name, string SSNum, string bDate, string address, string phone,
        string email)
        {
          
            for (int i = 0; i < SIZE; i++)
            {
                
                if (m_arrCustomerList[i] != null)
                {
                    
                    if (m_arrCustomerList[i].IDNumber == idNum)
                    {

                        m_arrCustomerList[i].Name = name;
                        m_arrCustomerList[i].SSNumber = SSNum;
                        m_arrCustomerList[i].BirthDate = bDate;
                        m_arrCustomerList[i].Address = address;
                        m_arrCustomerList[i].Phone = phone;
                        m_arrCustomerList[i].Email = email;
                       
                        return true;
                    }
                }
            }
          
            return false;
        }


        
        public bool Remove(string ID)
        {
            
            for (int i = 0; i < SIZE; i++)
            {
                
                if (m_arrCustomerList[i] != null)
                {
                   
                    if (m_arrCustomerList[i].IDNumber == ID)
                    {
                       
                        m_arrCustomerList[i] = null;
                        
                        return true;
                    }
                }
            }
          
            return false;
        }

       
        public bool Print(string ID)
        {
            
            for (int i = 0; i < SIZE; i++)
            {
             
                if (m_arrCustomerList[i] != null)
                {
                    
                    if (m_arrCustomerList[i].IDNumber == ID)
                    {
                        
                        m_arrCustomerList[i].Print();
                        return true; 
                    }
                }
            }
            
            return false;
        }

        
        public void PrintAll()
        {
            
            for (int i = 0; i < SIZE; i++)
            {
              
                if (m_arrCustomerList[i] != null)
                {
                    
                    m_arrCustomerList[i].Print();
                }
            }
        }

        
        public void Clear()
        {
            
            Array.Clear(m_arrCustomerList, m_arrCustomerList.GetLowerBound(0),
            m_arrCustomerList.GetUpperBound(0) + 1);
        }

        public Customer[] GetArrayCopy()
        {
            //Create temp array
            Customer[] arrTemp = new Customer[SIZE];
            m_arrCustomerList.CopyTo(arrTemp, m_arrCustomerList.GetLowerBound(0));
            return arrTemp;
        }

        
        public void Load()
        {
            string path = "CustomerData.txt";
            
            if (!File.Exists(path))
            {
                
                File.Create(path);
                Console.WriteLine("New file created");
            }
            
            StreamReader objFileReader = new StreamReader(path);

            string strLine;
            string[] strArray;
          
            Char[] delimiter = { ',' };
        
            strLine = objFileReader.ReadLine();
            
            while (strLine != null)
            {
                
                strArray = strLine.Split(delimiter);
                
                Customer objCustomer = new Customer();
               
                objCustomer.IDNumber = strArray[0];
                objCustomer.Name = strArray[1];
                objCustomer.SSNumber = strArray[2];
                objCustomer.BirthDate = strArray[3];
                objCustomer.Address = strArray[4];
                objCustomer.Phone = strArray[5];
                objCustomer.Email = strArray[6];
               
                this.Add(objCustomer);
               
                strLine = objFileReader.ReadLine();
            }
            
            objFileReader.Close();
        }

 
        public void Save()
        {
            string path = "CustomerData.txt";
            
            StreamWriter objFileWriter = new StreamWriter(path, false);
            
            string strLine;
            
            for (int i = 0; i < SIZE; i++)
            {
                
                if (m_arrCustomerList[i] != null)
                {
                    
                    strLine = m_arrCustomerList[i].IDNumber + ",";
                    strLine = strLine + m_arrCustomerList[i].Name + ",";
                    strLine = strLine + m_arrCustomerList[i].SSNumber + ",";
                    strLine = strLine + m_arrCustomerList[i].BirthDate + ",";
                    strLine = strLine + m_arrCustomerList[i].Address + ",";
                    strLine = strLine + m_arrCustomerList[i].Phone + ",";
                    strLine = strLine + m_arrCustomerList[i].Email;
                   
                    objFileWriter.WriteLine(strLine);
                }
            }
        
            objFileWriter.Close();
        }
        #endregion "Instance Array Processing Methods Declarations"

        #region "Static Methods"
    
        #endregion
    }
}
