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
            this.lblEmpID = new System.Windows.Forms.Label();
            this.cboEmpID = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gboTickBox = new System.Windows.Forms.GroupBox();
            this.txtTickDescription = new System.Windows.Forms.TextBox();
            this.txtTickTitle = new System.Windows.Forms.TextBox();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.lblTickComplete = new System.Windows.Forms.Label();
            this.lblTickDescription = new System.Windows.Forms.Label();
            this.lblCustAddress = new System.Windows.Forms.Label();
            this.lblCustName = new System.Windows.Forms.Label();
            this.ckbTickComplete = new System.Windows.Forms.CheckBox();
            this.gboTickBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTickNum
            // 
            this.lblTickNum.AutoSize = true;
            this.lblTickNum.Location = new System.Drawing.Point(7, 9);
            this.lblTickNum.Name = "lblTickNum";
            this.lblTickNum.Size = new System.Drawing.Size(47, 13);
            this.lblTickNum.TabIndex = 0;
            this.lblTickNum.Text = "Ticket #";
            // 
            // txtTickNum
            // 
            this.txtTickNum.Location = new System.Drawing.Point(10, 25);
            this.txtTickNum.Name = "txtTickNum";
            this.txtTickNum.ReadOnly = true;
            this.txtTickNum.Size = new System.Drawing.Size(41, 20);
            this.txtTickNum.TabIndex = 1;
            // 
            // lblEmpID
            // 
            this.lblEmpID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.Location = new System.Drawing.Point(334, 9);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(67, 13);
            this.lblEmpID.TabIndex = 2;
            this.lblEmpID.Text = "Employee ID";
            // 
            // cboEmpID
            // 
            this.cboEmpID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboEmpID.FormattingEnabled = true;
            this.cboEmpID.Location = new System.Drawing.Point(337, 25);
            this.cboEmpID.Name = "cboEmpID";
            this.cboEmpID.Size = new System.Drawing.Size(105, 21);
            this.cboEmpID.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(96, 266);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Location = new System.Drawing.Point(10, 266);
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
            this.gboTickBox.Controls.Add(this.ckbTickComplete);
            this.gboTickBox.Controls.Add(this.txtTickDescription);
            this.gboTickBox.Controls.Add(this.txtTickTitle);
            this.gboTickBox.Controls.Add(this.txtCustName);
            this.gboTickBox.Controls.Add(this.lblTickComplete);
            this.gboTickBox.Controls.Add(this.lblTickDescription);
            this.gboTickBox.Controls.Add(this.lblCustAddress);
            this.gboTickBox.Controls.Add(this.lblCustName);
            this.gboTickBox.Location = new System.Drawing.Point(12, 50);
            this.gboTickBox.Name = "gboTickBox";
            this.gboTickBox.Size = new System.Drawing.Size(428, 210);
            this.gboTickBox.TabIndex = 4;
            this.gboTickBox.TabStop = false;
            this.gboTickBox.Text = "Ticket";
            // 
            // txtTickDescription
            // 
            this.txtTickDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTickDescription.Location = new System.Drawing.Point(84, 76);
            this.txtTickDescription.Multiline = true;
            this.txtTickDescription.Name = "txtTickDescription";
            this.txtTickDescription.Size = new System.Drawing.Size(338, 100);
            this.txtTickDescription.TabIndex = 6;
            // 
            // txtTickTitle
            // 
            this.txtTickTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTickTitle.Location = new System.Drawing.Point(84, 48);
            this.txtTickTitle.Name = "txtTickTitle";
            this.txtTickTitle.Size = new System.Drawing.Size(338, 20);
            this.txtTickTitle.TabIndex = 5;
            // 
            // txtCustName
            // 
            this.txtCustName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustName.Location = new System.Drawing.Point(84, 20);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.ReadOnly = true;
            this.txtCustName.Size = new System.Drawing.Size(160, 20);
            this.txtCustName.TabIndex = 4;
            // 
            // lblTickComplete
            // 
            this.lblTickComplete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTickComplete.AutoSize = true;
            this.lblTickComplete.Location = new System.Drawing.Point(7, 182);
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
            this.lblTickDescription.Location = new System.Drawing.Point(6, 78);
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
            this.lblCustAddress.Location = new System.Drawing.Point(7, 51);
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
            this.lblCustName.Location = new System.Drawing.Point(7, 23);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(54, 13);
            this.lblCustName.TabIndex = 0;
            this.lblCustName.Text = "Customer:";
            // 
            // ckbTickComplete
            // 
            this.ckbTickComplete.AutoSize = true;
            this.ckbTickComplete.Location = new System.Drawing.Point(84, 182);
            this.ckbTickComplete.Name = "ckbTickComplete";
            this.ckbTickComplete.Size = new System.Drawing.Size(15, 14);
            this.ckbTickComplete.TabIndex = 7;
            this.ckbTickComplete.UseVisualStyleBackColor = true;
            // 
            // frmManageTick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 301);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gboTickBox);
            this.Controls.Add(this.cboEmpID);
            this.Controls.Add(this.lblEmpID);
            this.Controls.Add(this.txtTickNum);
            this.Controls.Add(this.lblTickNum);
            this.Name = "frmManageTick";
            this.Text = "frmManageTick";
            this.gboTickBox.ResumeLayout(false);
            this.gboTickBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTickNum;
        private System.Windows.Forms.TextBox txtTickNum;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.ComboBox cboEmpID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gboTickBox;
        private System.Windows.Forms.TextBox txtTickDescription;
        private System.Windows.Forms.TextBox txtTickTitle;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label lblTickComplete;
        private System.Windows.Forms.Label lblTickDescription;
        private System.Windows.Forms.Label lblCustAddress;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.CheckBox ckbTickComplete;
    }
}