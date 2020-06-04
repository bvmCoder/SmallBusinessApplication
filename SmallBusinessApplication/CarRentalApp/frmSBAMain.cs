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
    public partial class frmSBAMain : Form
    {
        public frmSBAMain()
        {
            InitializeComponent();
        }

        private void btnCustomerMgt_Click(object sender, EventArgs e)
        {
           
            frmCustomerMgt objCM = new frmCustomerMgt();
          
            this.Hide();
            objCM.ShowDialog();
            this.Show();

        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRetailMgt_Click(object sender, EventArgs e)
        {
            frmRetailMgt objRM = new frmRetailMgt();
            this.Hide();
            objRM.ShowDialog();
            this.Show();
        }
    }
}
