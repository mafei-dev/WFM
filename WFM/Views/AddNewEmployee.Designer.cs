﻿using WFM.Presenters;

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
            this.components = new System.ComponentModel.Container();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.dpBirthday = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.errorFName = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorFName)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(8, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 5, 3, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "NIC No";
            // 
            // txtAddress
            // 
            this.txtAddress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtAddress.Location = new System.Drawing.Point(90, 81);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(403, 102);
            this.txtAddress.TabIndex = 9;
            this.txtAddress.Enter += new System.EventHandler(this.txtAddress_Enter);
            // 
            // dpBirthday
            // 
            this.dpBirthday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dpBirthday.Location = new System.Drawing.Point(90, 215);
            this.dpBirthday.Name = "dpBirthday";
            this.dpBirthday.Size = new System.Drawing.Size(403, 20);
            this.dpBirthday.TabIndex = 8;
            this.dpBirthday.ValueChanged += new System.EventHandler(this.dpBirthday_ValueChanged);
            this.dpBirthday.Enter += new System.EventHandler(this.dpBirthday_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 217);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 5, 3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Birthday";
            // 
            // txtNIC
            // 
            this.txtNIC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNIC.Location = new System.Drawing.Point(90, 55);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(403, 20);
            this.txtNIC.TabIndex = 6;
            this.txtNIC.TextChanged += new System.EventHandler(this.txtNIC_TextChanged);
            this.txtNIC.Enter += new System.EventHandler(this.txtNIC_Enter);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 5, 3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 98);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(8, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 5, 3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            // 
            // txtLName
            // 
            this.txtLName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLName.Location = new System.Drawing.Point(90, 29);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(403, 20);
            this.txtLName.TabIndex = 2;
            this.txtLName.Enter += new System.EventHandler(this.txtLName_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 5, 3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // txtFName
            // 
            this.txtFName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtFName.Location = new System.Drawing.Point(90, 3);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(403, 20);
            this.txtFName.TabIndex = 0;
            this.txtFName.Enter += new System.EventHandler(this.txtFName_Enter);
            // 
            // errorFName
            // 
            this.errorFName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorFName.ContainerControl = this;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.87255F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.44582F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.681635F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtFName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtLName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtAddress, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNIC, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.dpBirthday, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnSubmit, 1, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(516, 272);
            this.tableLayoutPanel1.TabIndex = 3;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // btnSubmit
            // 
            this.btnSubmit.AutoSize = true;
            this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSubmit.Location = new System.Drawing.Point(340, 241);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(153, 28);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            this.btnSubmit.Validating += new System.ComponentModel.CancelEventHandler(this.btnSubmit_Validating);
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Checked = true;
            this.rbtnMale.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbtnMale.Location = new System.Drawing.Point(0, 0);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(48, 20);
            this.rbtnMale.TabIndex = 12;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            this.rbtnMale.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtnFemale);
            this.panel1.Controls.Add(this.rbtnMale);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(90, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 20);
            this.panel1.TabIndex = 14;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbtnFemale.Location = new System.Drawing.Point(48, 0);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(59, 20);
            this.rbtnFemale.TabIndex = 13;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 191);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 5, 3, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Gender";
            // 
            // AddNewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(516, 272);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddNewEmployee";
            ((System.ComponentModel.ISupportInitialize)(this.errorFName)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ErrorProvider errorFName;

        #endregion
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.Label label6;
    }
}