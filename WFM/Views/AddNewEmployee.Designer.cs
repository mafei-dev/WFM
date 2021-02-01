using WFM.Presenters;

namespace WFM.Views
{
    partial class AddNewEmployee
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dpBirthday = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.dpBirthday);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtNIC);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtLName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtFName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 332);
            this.panel1.TabIndex = 2;
            // 
            // dpBirthday
            // 
            this.dpBirthday.Location = new System.Drawing.Point(141, 198);
            this.dpBirthday.Name = "dpBirthday";
            this.dpBirthday.Size = new System.Drawing.Size(275, 20);
            this.dpBirthday.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Birthday";
            // 
            // txtNIC
            // 
            this.txtNIC.Location = new System.Drawing.Point(141, 64);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(275, 20);
            this.txtNIC.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(141, 38);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(275, 20);
            this.txtLName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(141, 12);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(275, 20);
            this.txtFName.TabIndex = 0;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(141, 90);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(275, 102);
            this.txtAddress.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "NIC No";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(141, 225);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(274, 23);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // AddNewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(429, 332);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddNewEmployee";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.DateTimePicker dpBirthday;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSubmit;
    }
}