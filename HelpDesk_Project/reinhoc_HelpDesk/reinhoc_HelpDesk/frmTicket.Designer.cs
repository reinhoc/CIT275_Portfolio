namespace reinhoc_HelpDesk
{
    partial class frmTicket
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
            this.lblEmployee = new System.Windows.Forms.Label();
            this.cboEmpID = new System.Windows.Forms.ComboBox();
            this.btnAddTick = new System.Windows.Forms.Button();
            this.btnEditTick = new System.Windows.Forms.Button();
            this.btnViewComplete = new System.Windows.Forms.Button();
            this.lstTickets = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(12, 9);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(53, 13);
            this.lblEmployee.TabIndex = 0;
            this.lblEmployee.Text = "Employee";
            // 
            // cboEmpID
            // 
            this.cboEmpID.FormattingEnabled = true;
            this.cboEmpID.Location = new System.Drawing.Point(12, 25);
            this.cboEmpID.Name = "cboEmpID";
            this.cboEmpID.Size = new System.Drawing.Size(159, 21);
            this.cboEmpID.TabIndex = 2;
            // 
            // btnAddTick
            // 
            this.btnAddTick.Location = new System.Drawing.Point(12, 70);
            this.btnAddTick.Name = "btnAddTick";
            this.btnAddTick.Size = new System.Drawing.Size(77, 23);
            this.btnAddTick.TabIndex = 4;
            this.btnAddTick.Text = "Add Ticket";
            this.btnAddTick.UseVisualStyleBackColor = true;
            // 
            // btnEditTick
            // 
            this.btnEditTick.Location = new System.Drawing.Point(96, 70);
            this.btnEditTick.Name = "btnEditTick";
            this.btnEditTick.Size = new System.Drawing.Size(75, 23);
            this.btnEditTick.TabIndex = 5;
            this.btnEditTick.Text = "Edit Ticket";
            this.btnEditTick.UseVisualStyleBackColor = true;
            // 
            // btnViewComplete
            // 
            this.btnViewComplete.Location = new System.Drawing.Point(178, 70);
            this.btnViewComplete.Name = "btnViewComplete";
            this.btnViewComplete.Size = new System.Drawing.Size(94, 23);
            this.btnViewComplete.TabIndex = 6;
            this.btnViewComplete.Text = "View Completed";
            this.btnViewComplete.UseVisualStyleBackColor = true;
            // 
            // lstTickets
            // 
            this.lstTickets.FormattingEnabled = true;
            this.lstTickets.Location = new System.Drawing.Point(12, 100);
            this.lstTickets.Name = "lstTickets";
            this.lstTickets.Size = new System.Drawing.Size(260, 134);
            this.lstTickets.TabIndex = 7;
            // 
            // frmTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lstTickets);
            this.Controls.Add(this.btnViewComplete);
            this.Controls.Add(this.btnEditTick);
            this.Controls.Add(this.btnAddTick);
            this.Controls.Add(this.cboEmpID);
            this.Controls.Add(this.lblEmployee);
            this.Name = "frmTicket";
            this.Text = "frmTicket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.ComboBox cboEmpID;
        private System.Windows.Forms.Button btnAddTick;
        private System.Windows.Forms.Button btnEditTick;
        private System.Windows.Forms.Button btnViewComplete;
        private System.Windows.Forms.ListBox lstTickets;
    }
}