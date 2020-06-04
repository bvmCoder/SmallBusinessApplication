using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class frmCustomerMgt : Form
    {
        #region "Modular-level Declarations"
       
        private CustomerList objCustomerList = new CustomerList();
      
        private Customer objCustomer;
        #endregion "Modular-level Declarations"

        public frmCustomerMgt()
        {
            InitializeComponent();
        }

        private void FrmCustomerMgt_Load(object sender, EventArgs e)
        {
            objCustomerList.Load();
            
            txtAge.ReadOnly = true;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            this.Close();

        }

        private void frmCustomerMgt_FormClosed(object sender, FormClosedEventArgs e)
        {
           
            objCustomer = null;
            
            objCustomerList.Save();
            
            objCustomerList.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {



            objCustomer = objCustomerList.Search(txtIDNumber.Text.Trim());
           
            if (objCustomer != null)
            {
                
                txtIDNumber.Text = objCustomer.IDNumber;
                txtName.Text = objCustomer.Name;
                txtSSNumber.Text = objCustomer.SSNumber;
                txtBirthDate.Text = objCustomer.BirthDate;
                txtAge.Text = objCustomer.Age.ToString(); 
                txtAddress.Text = objCustomer.Address;
                txtPhone.Text = objCustomer.Phone;
                txtEmail.Text = objCustomer.Email;
            }
            else
            {
               
                MessageBox.Show("Customer Not Found");
                
                txtIDNumber.Text = "";
                txtName.Text = "";
                txtSSNumber.Text = "";
                txtBirthDate.Text = "";
                txtAge.Text = "";
                txtAddress.Text = "";
                txtPhone.Text = "";
                txtEmail.Text = "";
            }

         }

        private void btnAdd_Click(object sender, EventArgs e)
        {
          
            bool success = objCustomerList.Add(txtIDNumber.Text.Trim(), txtName.Text.Trim(),
            txtSSNumber.Text.Trim(), txtBirthDate.Text, txtAddress.Text.Trim(), txtPhone.Text.Trim(),
            txtEmail.Text.Trim());
         
            if (success)
            {
                
                MessageBox.Show("Customer Added");
            }
            else
            {
             
                MessageBox.Show("No available space!");
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            {
                
                bool success = objCustomerList.Edit(txtIDNumber.Text.Trim(), txtName.Text.Trim(),
                txtSSNumber.Text.Trim(), txtBirthDate.Text, txtAddress.Text.Trim(), txtPhone.Text.Trim(),
                txtEmail.Text.Trim());
                //Process results
                if (success)
                {
                    
                    MessageBox.Show("Customer Edited");
                }
                else
                {
                    
                    MessageBox.Show("Customer Not Found!");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool success = objCustomerList.Remove(txtIDNumber.Text.Trim());

           
            if (success)             
            {                 
                       
                MessageBox.Show("Customer deleted");          
            }       
            else            
            {        
                MessageBox.Show("Customer Not Found!");     
            } 
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            bool success = objCustomerList.Print(txtIDNumber.Text.Trim());

          
            if (success)            
            {                 
               
                MessageBox.Show(" ****Customer record sent to printer * ***");   
            }           
            else            
            {                
                 
                MessageBox.Show("Customer Not Found!");       
            } 
        }

        private void btnPrintAll_Click(object sender, EventArgs e)
        {
            objCustomerList.PrintAll();
       
            MessageBox.Show(" **** All Customer records sent to printer  ***"); 

        }

        private void btnList_Click(object sender, EventArgs e)
        {
                      
            lstListAll.Items.Clear(); 

         
            Customer[] arrTempList = objCustomerList.GetArrayCopy(); 

    
            string strLine;          
            int SIZE1 = 5;           
            
            for (int i = 0; i < arrTempList.GetUpperBound(0) + 1; i++)     
            { 

         
                if (arrTempList[i] != null)         
                {              
                       
                    strLine = arrTempList[i].IDNumber + ",";     
                    strLine = strLine + arrTempList[i].Name + ",";    
                    strLine = strLine + arrTempList[i].SSNumber + ",";  
                    strLine = strLine + arrTempList[i].BirthDate + ",";
                    strLine = strLine + arrTempList[i].Address + ","; 
                    strLine = strLine + arrTempList[i].Phone + ",";  
                    strLine = strLine + arrTempList[i].Email; 

                  
                    lstListAll.Items.Add(strLine);   
                } 

        }
    }
    }
}
