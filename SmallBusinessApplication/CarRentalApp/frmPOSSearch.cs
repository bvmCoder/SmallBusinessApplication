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
    public partial class frmPOSSearch : Form
    {
        public frmPOSSearch()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmPOSSearch_Load(object sender, EventArgs e)
        {

        }

        private void grpExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            
            try
            {
               
                Customer objCustomer = new Customer();
                
                bool success = objCustomer.Load(txtSearchID.Text.Trim());
               
                if (success)
                {
                    
                    txtSearchID.Text = objCustomer.IDNumber;
                    txtName.Text = objCustomer.Name;
                    txtSSNumber.Text = objCustomer.SSNumber;
                    txtBirthDate.Text = objCustomer.BirthDate;
                    txtAge.Text = objCustomer.Age.ToString(); //convert to a string
                    txtAddress.Text = objCustomer.Address;
                    txtPhone.Text = objCustomer.Phone;
                    txtEmail.Text = objCustomer.Email;
                }
                else
                {
                    
                    MessageBox.Show("Customer Not Found");
                   
                    txtSearchID.Text = "";
                    txtName.Text = "";
                    txtSSNumber.Text = "";
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
    }
}
