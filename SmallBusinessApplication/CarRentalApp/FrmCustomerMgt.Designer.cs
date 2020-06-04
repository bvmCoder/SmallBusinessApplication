namespace CarRentalApp
{
    partial class frmCustomerMgt
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpCustomerData = new System.Windows.Forms.GroupBox();
            this.btnPrintAll = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBirthDate = new System.Windows.Forms.TextBox();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.txtSSNumber = new System.Windows.Forms.TextBox();
            this.lblSSNumber = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtIDNumber = new System.Windows.Forms.TextBox();
            this.lblIDNumber = new System.Windows.Forms.Label();
            this.grpList = new System.Windows.Forms.GroupBox();
            this.btnList = new System.Windows.Forms.Button();
            this.lstListAll = new System.Windows.Forms.ListBox();
            this.grpExit = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpCustomerData.SuspendLayout();
            this.grpList.SuspendLayout();
            this.grpExit.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(39, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(139, 13);
            this.lblTitle.TabIndex = 25;
            this.lblTitle.Text = "Customer Management form";
            // 
            // grpCustomerData
            // 
            this.grpCustomerData.Controls.Add(this.btnPrintAll);
            this.grpCustomerData.Controls.Add(this.btnPrint);
            this.grpCustomerData.Controls.Add(this.btnDelete);
            this.grpCustomerData.Controls.Add(this.btnEdit);
            this.grpCustomerData.Controls.Add(this.btnAdd);
            this.grpCustomerData.Controls.Add(this.btnSearch);
            this.grpCustomerData.Controls.Add(this.txtEmail);
            this.grpCustomerData.Controls.Add(this.label8);
            this.grpCustomerData.Controls.Add(this.txtPhone);
            this.grpCustomerData.Controls.Add(this.label7);
            this.grpCustomerData.Controls.Add(this.txtAddress);
            this.grpCustomerData.Controls.Add(this.label6);
            this.grpCustomerData.Controls.Add(this.txtAge);
            this.grpCustomerData.Controls.Add(this.label5);
            this.grpCustomerData.Controls.Add(this.txtBirthDate);
            this.grpCustomerData.Controls.Add(this.lblBirthDate);
            this.grpCustomerData.Controls.Add(this.txtSSNumber);
            this.grpCustomerData.Controls.Add(this.lblSSNumber);
            this.grpCustomerData.Controls.Add(this.txtName);
            this.grpCustomerData.Controls.Add(this.lblName);
            this.grpCustomerData.Controls.Add(this.txtIDNumber);
            this.grpCustomerData.Controls.Add(this.lblIDNumber);
            this.grpCustomerData.Location = new System.Drawing.Point(25, 91);
            this.grpCustomerData.Name = "grpCustomerData";
            this.grpCustomerData.Size = new System.Drawing.Size(371, 372);
            this.grpCustomerData.TabIndex = 26;
            this.grpCustomerData.TabStop = false;
            // 
            // btnPrintAll
            // 
            this.btnPrintAll.Location = new System.Drawing.Point(266, 272);
            this.btnPrintAll.Name = "btnPrintAll";
            this.btnPrintAll.Size = new System.Drawing.Size(75, 23);
            this.btnPrintAll.TabIndex = 44;
            this.btnPrintAll.Text = "Print All";
            this.btnPrintAll.UseVisualStyleBackColor = true;
            this.btnPrintAll.Click += new System.EventHandler(this.btnPrintAll_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(266, 215);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 43;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(266, 166);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 42;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(266, 117);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 41;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(266, 71);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 40;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(266, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 39;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(97, 326);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Email";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(97, 279);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Phone";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(97, 238);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Address";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(97, 196);
            this.txtAge.Name = "txtAge";
            this.txtAge.ReadOnly = true;
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Age";
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.Location = new System.Drawing.Point(97, 155);
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.Size = new System.Drawing.Size(100, 20);
            this.txtBirthDate.TabIndex = 30;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(30, 155);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(68, 13);
            this.lblBirthDate.TabIndex = 29;
            this.lblBirthDate.Text = "Date Of Bitrh";
            // 
            // txtSSNumber
            // 
            this.txtSSNumber.Location = new System.Drawing.Point(97, 114);
            this.txtSSNumber.Name = "txtSSNumber";
            this.txtSSNumber.Size = new System.Drawing.Size(100, 20);
            this.txtSSNumber.TabIndex = 28;
            // 
            // lblSSNumber
            // 
            this.lblSSNumber.AutoSize = true;
            this.lblSSNumber.Location = new System.Drawing.Point(30, 117);
            this.lblSSNumber.Name = "lblSSNumber";
            this.lblSSNumber.Size = new System.Drawing.Size(61, 13);
            this.lblSSNumber.TabIndex = 27;
            this.lblSSNumber.Text = "SS Number";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(97, 71);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 26;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 74);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 25;
            this.lblName.Text = "Name ";
            // 
            // txtIDNumber
            // 
            this.txtIDNumber.Location = new System.Drawing.Point(97, 26);
            this.txtIDNumber.Name = "txtIDNumber";
            this.txtIDNumber.Size = new System.Drawing.Size(100, 20);
            this.txtIDNumber.TabIndex = 24;
            // 
            // lblIDNumber
            // 
            this.lblIDNumber.AutoSize = true;
            this.lblIDNumber.Location = new System.Drawing.Point(30, 29);
            this.lblIDNumber.Name = "lblIDNumber";
            this.lblIDNumber.Size = new System.Drawing.Size(58, 13);
            this.lblIDNumber.TabIndex = 23;
            this.lblIDNumber.Text = "ID Number";
            // 
            // grpList
            // 
            this.grpList.Controls.Add(this.btnList);
            this.grpList.Controls.Add(this.lstListAll);
            this.grpList.Location = new System.Drawing.Point(402, 91);
            this.grpList.Name = "grpList";
            this.grpList.Size = new System.Drawing.Size(288, 276);
            this.grpList.TabIndex = 27;
            this.grpList.TabStop = false;
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(10, 239);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 23);
            this.btnList.TabIndex = 25;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // lstListAll
            // 
            this.lstListAll.FormattingEnabled = true;
            this.lstListAll.Location = new System.Drawing.Point(10, 14);
            this.lstListAll.Name = "lstListAll";
            this.lstListAll.Size = new System.Drawing.Size(269, 212);
            this.lstListAll.TabIndex = 24;
            // 
            // grpExit
            // 
            this.grpExit.Controls.Add(this.btnExit);
            this.grpExit.Location = new System.Drawing.Point(402, 394);
            this.grpExit.Name = "grpExit";
            this.grpExit.Size = new System.Drawing.Size(288, 69);
            this.grpExit.TabIndex = 28;
            this.grpExit.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(207, 33);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 25;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmCustomerMgt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 475);
            this.Controls.Add(this.grpExit);
            this.Controls.Add(this.grpList);
            this.Controls.Add(this.grpCustomerData);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmCustomerMgt";
            this.Text = "Customer Mangement";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCustomerMgt_FormClosed);
            this.Load += new System.EventHandler(this.FrmCustomerMgt_Load);
            this.grpCustomerData.ResumeLayout(false);
            this.grpCustomerData.PerformLayout();
            this.grpList.ResumeLayout(false);
            this.grpExit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpCustomerData;
        private System.Windows.Forms.Button btnPrintAll;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBirthDate;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.TextBox txtSSNumber;
        private System.Windows.Forms.Label lblSSNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtIDNumber;
        private System.Windows.Forms.Label lblIDNumber;
        private System.Windows.Forms.GroupBox grpList;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.ListBox lstListAll;
        private System.Windows.Forms.GroupBox grpExit;
        private System.Windows.Forms.Button btnExit;
    }
}