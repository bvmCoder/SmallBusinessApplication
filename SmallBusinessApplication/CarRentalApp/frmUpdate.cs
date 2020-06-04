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
    public partial class frmPOSUpdate : Form
    {
        #region "Modular-level Declarations"
       
        private Customer objCustomer;
        #endregion "Modular-level Declarations"

        public frmPOSUpdate()
        {
            InitializeComponent();
        }

        private void frmPOSUpdate_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            this.Close();

        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            
            try
            {
                objCustomer = new Customer();
                
                bool success = objCustomer.Load(txtSearchID.Text.Trim());
                
                if (success)
                {
                   
                    txtName.Text = objCustomer.Name;
                    txtSSName.Text = objCustomer.SSNumber;
                    txtBirthDate.Text = objCustomer.BirthDate;
                    txtAge.Text = objCustomer.Age.ToString(); //convert to a string
                    txtAddress.Text = objCustomer.Address;
                    txtPhone.Text = objCustomer.Phone;
                    txtEmail.Text = objCustomer.Email;
                }
                else
                {
                   
                    MessageBox.Show("Customer Not Found");
                    
                    txtName.Text = "";
                    txtSSName.Text = "";
                    txtBirthDate.Text = "";
                    txtAge.Text = "";
                    txtAddress.Text = "";
                    txtPhone.Text = "";
                    txtEmail.Text = "";
                }
            }
           
            catch (System.Exception)
            {
                
                MessageBox.Show("Error in search!");
            }

        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            
            try
            {
               
                objCustomer.Name = txtName.Text.Trim();
                objCustomer.SSNumber = txtSSName.Text.Trim();
                objCustomer.BirthDate = txtBirthDate.Text.Trim();
                objCustomer.Address = txtAddress.Text.Trim();
                objCustomer.Phone = txtPhone.Text.Trim();
                objCustomer.Email = txtEmail.Text.Trim();
                
                bool success = objCustomer.Update();
               
                if (success)
                {
                    
                    MessageBox.Show("Customer Updated");
                    
                    txtName.Text = "";
                    txtSSName.Text = "";
                    txtBirthDate.Text = "";
                    txtAddress.Text = "";
                    txtPhone.Text = "";
                    txtEmail.Text = "";
                }
                else
                {
                    
                    MessageBox.Show("Error! Customer was not Updated!");
                }
            }
          
            catch (System.Exception)
            {
                
                MessageBox.Show("Error! Customer was not Updated!");
            }
        }
    }
}
