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
    public partial class frmRetailMgt : Form
    {
        public frmRetailMgt()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            
            frmSales objST = new frmSales();
            
            this.Hide();
            objST.ShowDialog();
            this.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmPOSSearch objSearch = new frmPOSSearch();
            
            this.Hide();

            objSearch.ShowDialog();

            this.Show();

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmPOSRegister objReg = new frmPOSRegister();
           
            this.Hide();

            objReg.ShowDialog();

            this.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
            frmPOSUpdate objUpdate = new frmPOSUpdate();
           
            this.Hide();
            objUpdate.ShowDialog();

            this.Show();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
           
            frmPOSDelete objDelete = new frmPOSDelete();
        
            this.Hide();
            objDelete.ShowDialog();
            this.Show();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
          
            frmPOSList objList = new frmPOSList();
          
            this.Hide();
            objList.ShowDialog();
            this.Show();
        }

        private void frmRetailMgt_Load(object sender, EventArgs e)
        {
            
        }
    }
}
