namespace CarRentalApp
{
    partial class frmPOSList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpListCustomers = new System.Windows.Forms.GroupBox();
            this.lstListAll = new System.Windows.Forms.ListBox();
            this.btnListCustomrs = new System.Windows.Forms.Button();
            this.grpExit = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpListCustomers.SuspendLayout();
            this.grpExit.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpListCustomers
            // 
            this.grpListCustomers.Controls.Add(this.lstListAll);
            this.grpListCustomers.Controls.Add(this.btnListCustomrs);
            this.grpListCustomers.Location = new System.Drawing.Point(12, 30);
            this.grpListCustomers.Name = "grpListCustomers";
            this.grpListCustomers.Size = new System.Drawing.Size(541, 253);
            this.grpListCustomers.TabIndex = 0;
            this.grpListCustomers.TabStop = false;
            this.grpListCustomers.Text = "Click to list all Customer";
            // 
            // lstListAll
            // 
            this.lstListAll.FormattingEnabled = true;
            this.lstListAll.Location = new System.Drawing.Point(39, 73);
            this.lstListAll.Name = "lstListAll";
            this.lstListAll.Size = new System.Drawing.Size(484, 160);
            this.lstListAll.TabIndex = 1;
            // 
            // btnListCustomrs
            // 
            this.btnListCustomrs.Location = new System.Drawing.Point(28, 32);
            this.btnListCustomrs.Name = "btnListCustomrs";
            this.btnListCustomrs.Size = new System.Drawing.Size(122, 23);
            this.btnListCustomrs.TabIndex = 0;
            this.btnListCustomrs.Text = "List Customer";
            this.btnListCustomrs.UseVisualStyleBackColor = true;
            this.btnListCustomrs.Click += new System.EventHandler(this.btnListCustomrs_Click);
            // 
            // grpExit
            // 
            this.grpExit.Controls.Add(this.btnExit);
            this.grpExit.Location = new System.Drawing.Point(12, 299);
            this.grpExit.Name = "grpExit";
            this.grpExit.Size = new System.Drawing.Size(541, 55);
            this.grpExit.TabIndex = 1;
            this.grpExit.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(436, 19);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 27);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmPOSList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 411);
            this.Controls.Add(this.grpExit);
            this.Controls.Add(this.grpListCustomers);
            this.Name = "frmPOSList";
            this.Text = "List Customer Form";
            this.grpListCustomers.ResumeLayout(false);
            this.grpExit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpListCustomers;
        private System.Windows.Forms.ListBox lstListAll;
        private System.Windows.Forms.Button btnListCustomrs;
        private System.Windows.Forms.GroupBox grpExit;
        private System.Windows.Forms.Button btnExit;
    }
}