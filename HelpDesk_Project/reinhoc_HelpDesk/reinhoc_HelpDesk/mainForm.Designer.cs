namespace reinhoc_HelpDesk
{
    partial class mainForm
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
            this.cboCustList = new System.Windows.Forms.ComboBox();
            this.lblCust = new System.Windows.Forms.Label();
            this.btnAddCust = new System.Windows.Forms.Button();
            this.btnTicket = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboCustList
            // 
            this.cboCustList.FormattingEnabled = true;
            this.cboCustList.Location = new System.Drawing.Point(151, 13);
            this.cboCustList.Name = "cboCustList";
            this.cboCustList.Size = new System.Drawing.Size(182, 21);
            this.cboCustList.TabIndex = 0;
            // 
            // lblCust
            // 
            this.lblCust.AutoSize = true;
            this.lblCust.Location = new System.Drawing.Point(91, 16);
            this.lblCust.Name = "lblCust";
            this.lblCust.Size = new System.Drawing.Size(54, 13);
            this.lblCust.TabIndex = 1;
            this.lblCust.Text = "Customer:";
            // 
            // btnAddCust
            // 
            this.btnAddCust.Location = new System.Drawing.Point(13, 59);
            this.btnAddCust.Name = "btnAddCust";
            this.btnAddCust.Size = new System.Drawing.Size(132, 108);
            this.btnAddCust.TabIndex = 2;
            this.btnAddCust.Text = "Add Customer";
            this.btnAddCust.UseVisualStyleBackColor = true;
            // 
            // btnTicket
            // 
            this.btnTicket.Location = new System.Drawing.Point(152, 59);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(156, 108);
            this.btnTicket.TabIndex = 3;
            this.btnTicket.Text = "btnTicket";
            this.btnTicket.UseVisualStyleBackColor = true;
            // 
            // btnEmployee
            // 
            this.btnEmployee.Location = new System.Drawing.Point(314, 59);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(146, 108);
            this.btnEmployee.TabIndex = 4;
            this.btnEmployee.Text = "Add Employee";
            this.btnEmployee.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 179);
            this.Controls.Add(this.btnEmployee);
            this.Controls.Add(this.btnTicket);
            this.Controls.Add(this.btnAddCust);
            this.Controls.Add(this.lblCust);
            this.Controls.Add(this.cboCustList);
            this.Name = "mainForm";
            this.Text = "Help Desk Tracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCustList;
        private System.Windows.Forms.Label lblCust;
        private System.Windows.Forms.Button btnAddCust;
        private System.Windows.Forms.Button btnTicket;
        private System.Windows.Forms.Button btnEmployee;
    }
}

