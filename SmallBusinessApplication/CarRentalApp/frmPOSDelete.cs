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
    public partial class frmPOSDelete : Form
    {
        public frmPOSDelete()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            this.Close();

        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                Customer objCustomer = new Customer();
               
                bool success = objCustomer.Delete(txtSearchID.Text.Trim());
               
                if (success)
                {
                   
                    MessageBox.Show("Customer Deleted");
                }
                else
                {
                    
                    MessageBox.Show("Customer Not Found");
                    
                    txtSearchID.Text = "";
                }
            }
            catch (System.Exception)
            {
              
                MessageBox.Show("Error Deleting customer!");
            }

        }
    }
}
