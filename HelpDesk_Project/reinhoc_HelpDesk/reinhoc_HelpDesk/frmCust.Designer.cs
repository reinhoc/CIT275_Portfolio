namespace reinhoc_HelpDesk
{
    partial class frmCust
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
            this.gboCustBox = new System.Windows.Forms.GroupBox();
            this.txtCustZip = new System.Windows.Forms.TextBox();
            this.txtCustState = new System.Windows.Forms.TextBox();
            this.txtCustAddress = new System.Windows.Forms.TextBox();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.lblCustZip = new System.Windows.Forms.Label();
            this.lblCustState = new System.Windows.Forms.Label();
            this.lblCustAddress = new System.Windows.Forms.Label();
            this.lblCustName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gboCustBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboCustBox
            // 
            this.gboCustBox.Controls.Add(this.txtCustZip);
            this.gboCustBox.Controls.Add(this.txtCustState);
            this.gboCustBox.Controls.Add(this.txtCustAddress);
            this.gboCustBox.Controls.Add(this.txtCustName);
            this.gboCustBox.Controls.Add(this.lblCustZip);
            this.gboCustBox.Controls.Add(this.lblCustState);
            this.gboCustBox.Controls.Add(this.lblCustAddress);
            this.gboCustBox.Controls.Add(this.lblCustName);
            this.gboCustBox.Location = new System.Drawing.Point(12, 12);
            this.gboCustBox.Name = "gboCustBox";
            this.gboCustBox.Size = new System.Drawing.Size(260, 133);
            this.gboCustBox.TabIndex = 0;
            this.gboCustBox.TabStop = false;
            this.gboCustBox.Text = "Customer";
            // 
            // txtCustZip
            // 
            this.txtCustZip.Location = new System.Drawing.Point(68, 102);
            this.txtCustZip.Name = "txtCustZip";
            this.txtCustZip.Size = new System.Drawing.Size(88, 20);
            this.txtCustZip.TabIndex = 7;
            // 
            // txtCustState
            // 
            this.txtCustState.Location = new System.Drawing.Point(68, 75);
            this.txtCustState.Name = "txtCustState";
            this.txtCustState.Size = new System.Drawing.Size(88, 20);
            this.txtCustState.TabIndex = 6;
            // 
            // txtCustAddress
            // 
            this.txtCustAddress.Location = new System.Drawing.Point(68, 48);
            this.txtCustAddress.Name = "txtCustAddress";
            this.txtCustAddress.Size = new System.Drawing.Size(186, 20);
            this.txtCustAddress.TabIndex = 5;
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(68, 20);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(186, 20);
            this.txtCustName.TabIndex = 4;
            // 
            // lblCustZip
            // 
            this.lblCustZip.AutoSize = true;
            this.lblCustZip.Location = new System.Drawing.Point(7, 105);
            this.lblCustZip.Name = "lblCustZip";
            this.lblCustZip.Size = new System.Drawing.Size(53, 13);
            this.lblCustZip.TabIndex = 3;
            this.lblCustZip.Text = "Zip Code:";
            // 
            // lblCustState
            // 
            this.lblCustState.AutoSize = true;
            this.lblCustState.Location = new System.Drawing.Point(6, 78);
            this.lblCustState.Name = "lblCustState";
            this.lblCustState.Size = new System.Drawing.Size(35, 13);
            this.lblCustState.TabIndex = 2;
            this.lblCustState.Text = "State:";
            // 
            // lblCustAddress
            // 
            this.lblCustAddress.AutoSize = true;
            this.lblCustAddress.Location = new System.Drawing.Point(7, 51);
            this.lblCustAddress.Name = "lblCustAddress";
            this.lblCustAddress.Size = new System.Drawing.Size(48, 13);
            this.lblCustAddress.TabIndex = 1;
            this.lblCustAddress.Text = "Address:";
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(7, 23);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(54, 13);
            this.lblCustName.TabIndex = 0;
            this.lblCustName.Text = "Customer:";
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Location = new System.Drawing.Point(21, 152);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(103, 152);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmCust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 190);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gboCustBox);
            this.Name = "frmCust";
            this.Text = "Add Customer";
            this.gboCustBox.ResumeLayout(false);
            this.gboCustBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboCustBox;
        private System.Windows.Forms.TextBox txtCustZip;
        private System.Windows.Forms.TextBox txtCustState;
        private System.Windows.Forms.TextBox txtCustAddress;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label lblCustZip;
        private System.Windows.Forms.Label lblCustState;
        private System.Windows.Forms.Label lblCustAddress;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
    }
}