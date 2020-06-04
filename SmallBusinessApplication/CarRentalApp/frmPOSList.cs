using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 
using System.Data.SqlClient;

namespace CarRentalApp
{
    public partial class frmPOSList : Form
    {
        #region "Connection String Declaration"
        
        private string strConn = "Data Source=DESKTOP-VDQVKUL\\SQLEXPRESS;Initial Catalog=SmallBusinessDB;Integrated Security=True";
         #endregion
        public frmPOSList()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            this.Close();

        }

        private void btnListCustomrs_Click(object sender, EventArgs e)
        {
            
            SqlConnection objConn = new SqlConnection(strConn);
            
            try
            {
               
                objConn.Open();
                
                string strSQL = "SELECT * FROM Customer;";
               
                SqlCommand objCmd = new SqlCommand(strSQL, objConn);
                
                objCmd.CommandType = CommandType.Text;
                
                SqlDataReader objDR = objCmd.ExecuteReader();
                
                if (objDR.HasRows)
                {
                    
                    lstListAll.Items.Clear();
                    
                    string strLine;
                   
                    while (objDR.Read())
                    {
                       
                        strLine = objDR.GetString(0) + ",";
                        strLine = strLine + objDR.GetString(1) + ",";
                        strLine = strLine + objDR.GetString(2) + ",";
                        strLine = strLine + objDR.GetString(3) + ",";
                        strLine = strLine + objDR.GetString(4) + ",";
                        strLine = strLine + objDR.GetString(5) + ",";
                        strLine = strLine + objDR.GetString(6);
                      
                        lstListAll.Items.Add(strLine);
                    }
                }
                else
                {
                   
                    MessageBox.Show("No CustomersFound");
                }
                objDR.Close();
                objDR = null;
                objCmd.Dispose();
                objCmd = null;
            }
            catch (System.Exception)
            {
                
                MessageBox.Show("Error Listing customers!");
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
