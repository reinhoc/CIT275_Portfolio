namespace reinhoc_HelpDesk
{
    partial class empForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gboCustBox = new System.Windows.Forms.GroupBox();
            this.txtCustState = new System.Windows.Forms.TextBox();
            this.txtCustAddress = new System.Windows.Forms.TextBox();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.lblEmpUName = new System.Windows.Forms.Label();
            this.lblEmpLName = new System.Windows.Forms.Label();
            this.lblEmpFName = new System.Windows.Forms.Label();
            this.gboCustBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(102, 129);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Location = new System.Drawing.Point(21, 129);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // gboCustBox
            // 
            this.gboCustBox.Controls.Add(this.txtCustState);
            this.gboCustBox.Controls.Add(this.txtCustAddress);
            this.gboCustBox.Controls.Add(this.txtCustName);
            this.gboCustBox.Controls.Add(this.lblEmpUName);
            this.gboCustBox.Controls.Add(this.lblEmpLName);
            this.gboCustBox.Controls.Add(this.lblEmpFName);
            this.gboCustBox.Location = new System.Drawing.Point(12, 12);
            this.gboCustBox.Name = "gboCustBox";
            this.gboCustBox.Size = new System.Drawing.Size(260, 111);
            this.gboCustBox.TabIndex = 3;
            this.gboCustBox.TabStop = false;
            this.gboCustBox.Text = "Customer";
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
            // lblEmpUName
            // 
            this.lblEmpUName.AutoSize = true;
            this.lblEmpUName.Location = new System.Drawing.Point(6, 78);
            this.lblEmpUName.Name = "lblEmpUName";
            this.lblEmpUName.Size = new System.Drawing.Size(58, 13);
            this.lblEmpUName.TabIndex = 2;
            this.lblEmpUName.Text = "Username:";
            // 
            // lblEmpLName
            // 
            this.lblEmpLName.AutoSize = true;
            this.lblEmpLName.Location = new System.Drawing.Point(7, 51);
            this.lblEmpLName.Name = "lblEmpLName";
            this.lblEmpLName.Size = new System.Drawing.Size(61, 13);
            this.lblEmpLName.TabIndex = 1;
            this.lblEmpLName.Text = "Last Name:";
            // 
            // lblEmpFName
            // 
            this.lblEmpFName.AutoSize = true;
            this.lblEmpFName.Location = new System.Drawing.Point(7, 23);
            this.lblEmpFName.Name = "lblEmpFName";
            this.lblEmpFName.Size = new System.Drawing.Size(60, 13);
            this.lblEmpFName.TabIndex = 0;
            this.lblEmpFName.Text = "First Name:";
            // 
            // empForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 173);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gboCustBox);
            this.Name = "empForm";
            this.Text = "Add Employee";
            this.gboCustBox.ResumeLayout(false);
            this.gboCustBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gboCustBox;
        private System.Windows.Forms.TextBox txtCustState;
        private System.Windows.Forms.TextBox txtCustAddress;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label lblEmpUName;
        private System.Windows.Forms.Label lblEmpLName;
        private System.Windows.Forms.Label lblEmpFName;
    }
}