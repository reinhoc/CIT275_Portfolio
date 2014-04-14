namespace reinhoc_HelpDesk
{
    partial class frmManageTick
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
            this.lblTickNum = new System.Windows.Forms.Label();
            this.txtTickNum = new System.Windows.Forms.TextBox();
            this.lblSearchEmpUN = new System.Windows.Forms.Label();
            this.cboSearchEmp = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gboTickBox = new System.Windows.Forms.GroupBox();
            this.ckbTickComplete = new System.Windows.Forms.CheckBox();
            this.txtTickDescription = new System.Windows.Forms.TextBox();
            this.txtTickTitle = new System.Windows.Forms.TextBox();
            this.lblTickComplete = new System.Windows.Forms.Label();
            this.lblTickDescription = new System.Windows.Forms.Label();
            this.lblCustAddress = new System.Windows.Forms.Label();
            this.lblCustName = new System.Windows.Forms.Label();
            this.txtFixDescription = new System.Windows.Forms.TextBox();
            this.lblFixDescription = new System.Windows.Forms.Label();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.lblEmpUN = new System.Windows.Forms.Label();
            this.cboUserName = new System.Windows.Forms.ComboBox();
            this.lblSearchTicketID = new System.Windows.Forms.Label();
            this.cboSearchTicket = new System.Windows.Forms.ComboBox();
            this.cboSearchCustomer = new System.Windows.Forms.ComboBox();
            this.lblSearchCustomer = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblSeverity = new System.Windows.Forms.Label();
            this.numSeverity = new System.Windows.Forms.NumericUpDown();
            this.gboTickBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSeverity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTickNum
            // 
            this.lblTickNum.AutoSize = true;
            this.lblTickNum.Location = new System.Drawing.Point(6, 16);
            this.lblTickNum.Name = "lblTickNum";
            this.lblTickNum.Size = new System.Drawing.Size(47, 13);
            this.lblTickNum.TabIndex = 0;
            this.lblTickNum.Text = "Ticket #";
            // 
            // txtTickNum
            // 
            this.txtTickNum.Location = new System.Drawing.Point(84, 16);
            this.txtTickNum.Name = "txtTickNum";
            this.txtTickNum.ReadOnly = true;
            this.txtTickNum.Size = new System.Drawing.Size(41, 20);
            this.txtTickNum.TabIndex = 1;
            // 
            // lblSearchEmpUN
            // 
            this.lblSearchEmpUN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearchEmpUN.AutoSize = true;
            this.lblSearchEmpUN.Location = new System.Drawing.Point(334, 9);
            this.lblSearchEmpUN.Name = "lblSearchEmpUN";
            this.lblSearchEmpUN.Size = new System.Drawing.Size(112, 13);
            this.lblSearchEmpUN.TabIndex = 2;
            this.lblSearchEmpUN.Text = "Employee User Name:";
            // 
            // cboSearchEmp
            // 
            this.cboSearchEmp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSearchEmp.FormattingEnabled = true;
            this.cboSearchEmp.Location = new System.Drawing.Point(337, 25);
            this.cboSearchEmp.Name = "cboSearchEmp";
            this.cboSearchEmp.Size = new System.Drawing.Size(105, 21);
            this.cboSearchEmp.TabIndex = 3;
            this.cboSearchEmp.SelectedIndexChanged += new System.EventHandler(this.cboSearchEmp_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(96, 392);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(10, 392);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // gboTickBox
            // 
            this.gboTickBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboTickBox.Controls.Add(this.numSeverity);
            this.gboTickBox.Controls.Add(this.lblSeverity);
            this.gboTickBox.Controls.Add(this.cboUserName);
            this.gboTickBox.Controls.Add(this.lblEmpUN);
            this.gboTickBox.Controls.Add(this.cboCustomer);
            this.gboTickBox.Controls.Add(this.txtFixDescription);
            this.gboTickBox.Controls.Add(this.lblFixDescription);
            this.gboTickBox.Controls.Add(this.ckbTickComplete);
            this.gboTickBox.Controls.Add(this.txtTickDescription);
            this.gboTickBox.Controls.Add(this.txtTickTitle);
            this.gboTickBox.Controls.Add(this.txtTickNum);
            this.gboTickBox.Controls.Add(this.lblTickNum);
            this.gboTickBox.Controls.Add(this.lblTickComplete);
            this.gboTickBox.Controls.Add(this.lblTickDescription);
            this.gboTickBox.Controls.Add(this.lblCustAddress);
            this.gboTickBox.Controls.Add(this.lblCustName);
            this.gboTickBox.Location = new System.Drawing.Point(12, 50);
            this.gboTickBox.Name = "gboTickBox";
            this.gboTickBox.Size = new System.Drawing.Size(428, 336);
            this.gboTickBox.TabIndex = 4;
            this.gboTickBox.TabStop = false;
            this.gboTickBox.Text = "Ticket";
            // 
            // ckbTickComplete
            // 
            this.ckbTickComplete.AutoSize = true;
            this.ckbTickComplete.Location = new System.Drawing.Point(84, 210);
            this.ckbTickComplete.Name = "ckbTickComplete";
            this.ckbTickComplete.Size = new System.Drawing.Size(15, 14);
            this.ckbTickComplete.TabIndex = 7;
            this.ckbTickComplete.UseVisualStyleBackColor = true;
            // 
            // txtTickDescription
            // 
            this.txtTickDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTickDescription.Location = new System.Drawing.Point(84, 104);
            this.txtTickDescription.Multiline = true;
            this.txtTickDescription.Name = "txtTickDescription";
            this.txtTickDescription.Size = new System.Drawing.Size(338, 100);
            this.txtTickDescription.TabIndex = 6;
            // 
            // txtTickTitle
            // 
            this.txtTickTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTickTitle.Location = new System.Drawing.Point(84, 78);
            this.txtTickTitle.Name = "txtTickTitle";
            this.txtTickTitle.Size = new System.Drawing.Size(338, 20);
            this.txtTickTitle.TabIndex = 5;
            // 
            // lblTickComplete
            // 
            this.lblTickComplete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTickComplete.AutoSize = true;
            this.lblTickComplete.Location = new System.Drawing.Point(6, 210);
            this.lblTickComplete.Name = "lblTickComplete";
            this.lblTickComplete.Size = new System.Drawing.Size(66, 13);
            this.lblTickComplete.TabIndex = 3;
            this.lblTickComplete.Text = "Completed?:";
            // 
            // lblTickDescription
            // 
            this.lblTickDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTickDescription.AutoSize = true;
            this.lblTickDescription.Location = new System.Drawing.Point(6, 104);
            this.lblTickDescription.Name = "lblTickDescription";
            this.lblTickDescription.Size = new System.Drawing.Size(63, 13);
            this.lblTickDescription.TabIndex = 2;
            this.lblTickDescription.Text = "Description:";
            // 
            // lblCustAddress
            // 
            this.lblCustAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCustAddress.AutoSize = true;
            this.lblCustAddress.Location = new System.Drawing.Point(6, 81);
            this.lblCustAddress.Name = "lblCustAddress";
            this.lblCustAddress.Size = new System.Drawing.Size(71, 13);
            this.lblCustAddress.TabIndex = 1;
            this.lblCustAddress.Text = "Problem Title:";
            // 
            // lblCustName
            // 
            this.lblCustName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(6, 55);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(54, 13);
            this.lblCustName.TabIndex = 0;
            this.lblCustName.Text = "Customer:";
            // 
            // txtFixDescription
            // 
            this.txtFixDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFixDescription.Location = new System.Drawing.Point(84, 230);
            this.txtFixDescription.Multiline = true;
            this.txtFixDescription.Name = "txtFixDescription";
            this.txtFixDescription.Size = new System.Drawing.Size(338, 100);
            this.txtFixDescription.TabIndex = 9;
            // 
            // lblFixDescription
            // 
            this.lblFixDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFixDescription.AutoSize = true;
            this.lblFixDescription.Location = new System.Drawing.Point(6, 230);
            this.lblFixDescription.Name = "lblFixDescription";
            this.lblFixDescription.Size = new System.Drawing.Size(79, 13);
            this.lblFixDescription.TabIndex = 8;
            this.lblFixDescription.Text = "Fix Description:";
            // 
            // cboCustomer
            // 
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(84, 51);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(338, 21);
            this.cboCustomer.TabIndex = 10;
            // 
            // lblEmpUN
            // 
            this.lblEmpUN.AutoSize = true;
            this.lblEmpUN.Location = new System.Drawing.Point(131, 16);
            this.lblEmpUN.Name = "lblEmpUN";
            this.lblEmpUN.Size = new System.Drawing.Size(63, 13);
            this.lblEmpUN.TabIndex = 11;
            this.lblEmpUN.Text = "User Name:";
            // 
            // cboUserName
            // 
            this.cboUserName.FormattingEnabled = true;
            this.cboUserName.Location = new System.Drawing.Point(200, 13);
            this.cboUserName.Name = "cboUserName";
            this.cboUserName.Size = new System.Drawing.Size(222, 21);
            this.cboUserName.TabIndex = 12;
            // 
            // lblSearchTicketID
            // 
            this.lblSearchTicketID.AutoSize = true;
            this.lblSearchTicketID.Location = new System.Drawing.Point(13, 8);
            this.lblSearchTicketID.Name = "lblSearchTicketID";
            this.lblSearchTicketID.Size = new System.Drawing.Size(50, 13);
            this.lblSearchTicketID.TabIndex = 7;
            this.lblSearchTicketID.Text = "Ticket #:";
            // 
            // cboSearchTicket
            // 
            this.cboSearchTicket.FormattingEnabled = true;
            this.cboSearchTicket.Location = new System.Drawing.Point(16, 25);
            this.cboSearchTicket.Name = "cboSearchTicket";
            this.cboSearchTicket.Size = new System.Drawing.Size(65, 21);
            this.cboSearchTicket.TabIndex = 8;
            this.cboSearchTicket.SelectedIndexChanged += new System.EventHandler(this.cboSearchTicket_SelectedIndexChanged);
            // 
            // cboSearchCustomer
            // 
            this.cboSearchCustomer.FormattingEnabled = true;
            this.cboSearchCustomer.Location = new System.Drawing.Point(161, 25);
            this.cboSearchCustomer.Name = "cboSearchCustomer";
            this.cboSearchCustomer.Size = new System.Drawing.Size(121, 21);
            this.cboSearchCustomer.TabIndex = 9;
            this.cboSearchCustomer.SelectedIndexChanged += new System.EventHandler(this.cboSearchCustomer_SelectedIndexChanged);
            // 
            // lblSearchCustomer
            // 
            this.lblSearchCustomer.AutoSize = true;
            this.lblSearchCustomer.Location = new System.Drawing.Point(161, 8);
            this.lblSearchCustomer.Name = "lblSearchCustomer";
            this.lblSearchCustomer.Size = new System.Drawing.Size(54, 13);
            this.lblSearchCustomer.TabIndex = 10;
            this.lblSearchCustomer.Text = "Customer:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(178, 391);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblSeverity
            // 
            this.lblSeverity.AutoSize = true;
            this.lblSeverity.Location = new System.Drawing.Point(106, 209);
            this.lblSeverity.Name = "lblSeverity";
            this.lblSeverity.Size = new System.Drawing.Size(48, 13);
            this.lblSeverity.TabIndex = 13;
            this.lblSeverity.Text = "Severity:";
            // 
            // numSeverity
            // 
            this.numSeverity.Location = new System.Drawing.Point(160, 208);
            this.numSeverity.Name = "numSeverity";
            this.numSeverity.Size = new System.Drawing.Size(34, 20);
            this.numSeverity.TabIndex = 14;
            // 
            // frmManageTick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 427);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblSearchCustomer);
            this.Controls.Add(this.cboSearchCustomer);
            this.Controls.Add(this.cboSearchTicket);
            this.Controls.Add(this.lblSearchTicketID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gboTickBox);
            this.Controls.Add(this.cboSearchEmp);
            this.Controls.Add(this.lblSearchEmpUN);
            this.Name = "frmManageTick";
            this.Text = "Add/Edit Tickets";
            this.gboTickBox.ResumeLayout(false);
            this.gboTickBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSeverity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTickNum;
        private System.Windows.Forms.TextBox txtTickNum;
        private System.Windows.Forms.Label lblSearchEmpUN;
        private System.Windows.Forms.ComboBox cboSearchEmp;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gboTickBox;
        private System.Windows.Forms.TextBox txtTickDescription;
        private System.Windows.Forms.TextBox txtTickTitle;
        private System.Windows.Forms.Label lblTickComplete;
        private System.Windows.Forms.Label lblTickDescription;
        private System.Windows.Forms.Label lblCustAddress;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.CheckBox ckbTickComplete;
        private System.Windows.Forms.Label lblEmpUN;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.TextBox txtFixDescription;
        private System.Windows.Forms.Label lblFixDescription;
        private System.Windows.Forms.ComboBox cboUserName;
        private System.Windows.Forms.Label lblSearchTicketID;
        private System.Windows.Forms.ComboBox cboSearchTicket;
        private System.Windows.Forms.ComboBox cboSearchCustomer;
        private System.Windows.Forms.Label lblSearchCustomer;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.NumericUpDown numSeverity;
        private System.Windows.Forms.Label lblSeverity;
    }
}