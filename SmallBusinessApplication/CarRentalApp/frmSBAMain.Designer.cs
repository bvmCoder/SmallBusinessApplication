namespace CarRentalApp
{
    partial class frmSBAMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCustomerMgt = new System.Windows.Forms.Button();
            this.btnExist = new System.Windows.Forms.Button();
            this.btnRetailMgt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Small Bussiness Application";
            // 
            // btnCustomerMgt
            // 
            this.btnCustomerMgt.Location = new System.Drawing.Point(155, 105);
            this.btnCustomerMgt.Name = "btnCustomerMgt";
            this.btnCustomerMgt.Size = new System.Drawing.Size(259, 36);
            this.btnCustomerMgt.TabIndex = 1;
            this.btnCustomerMgt.Text = "Customer Management";
            this.btnCustomerMgt.UseVisualStyleBackColor = true;
            this.btnCustomerMgt.Click += new System.EventHandler(this.btnCustomerMgt_Click);
            // 
            // btnExist
            // 
            this.btnExist.Location = new System.Drawing.Point(155, 233);
            this.btnExist.Name = "btnExist";
            this.btnExist.Size = new System.Drawing.Size(259, 36);
            this.btnExist.TabIndex = 2;
            this.btnExist.Text = "Exit Program";
            this.btnExist.UseVisualStyleBackColor = true;
            this.btnExist.Click += new System.EventHandler(this.btnExist_Click);
            // 
            // btnRetailMgt
            // 
            this.btnRetailMgt.Location = new System.Drawing.Point(155, 168);
            this.btnRetailMgt.Name = "btnRetailMgt";
            this.btnRetailMgt.Size = new System.Drawing.Size(259, 36);
            this.btnRetailMgt.TabIndex = 3;
            this.btnRetailMgt.Text = "Retail Point of Sales";
            this.btnRetailMgt.UseVisualStyleBackColor = true;
            this.btnRetailMgt.Click += new System.EventHandler(this.btnRetailMgt_Click);
            // 
            // frmSBAMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 358);
            this.Controls.Add(this.btnRetailMgt);
            this.Controls.Add(this.btnExist);
            this.Controls.Add(this.btnCustomerMgt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmSBAMain";
            this.Text = "Small Business Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCustomerMgt;
        private System.Windows.Forms.Button btnExist;
        private System.Windows.Forms.Button btnRetailMgt;
    }
}

