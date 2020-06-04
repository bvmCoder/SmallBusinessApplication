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
    public partial class frmPOSRegister : Form
    {
        public frmPOSRegister()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

   
        private void btnRegisterCustomer_Click(object sender, EventArgs e)
        {
           
            try
            {
               
                Customer objCustomer = new Customer();
                
                objCustomer.IDNumber = txtIDNumber.Text.Trim();
                objCustomer.Name = txtName.Text.Trim();
                objCustomer.SSNumber = txtSSNumber.Text.Trim();
                objCustomer.BirthDate = txtBirthDate.Text.Trim();
                objCustomer.Address = txtAddress.Text.Trim();
                objCustomer.Phone = txtPhone.Text.Trim();
                objCustomer.Email = txtEmail.Text.Trim();
                
                bool success = objCustomer.Insert();
              
                if (success)
                {
                   
                    MessageBox.Show("Customer Added");
                   
                    txtIDNumber.Text = "";
                    txtName.Text = "";
                    txtSSNumber.Text = "";
                    txtBirthDate.Text = "";
                    txtAddress.Text = "";
                    txtPhone.Text = "";
                    txtEmail.Text = "";
                }
                else
                {
                  
                    MessageBox.Show("Error! Customer was not added!");
                }
            }
            catch (System.Exception)
            {
                
                MessageBox.Show("Error! Customer was not added!");
            }
        }
    }
}
