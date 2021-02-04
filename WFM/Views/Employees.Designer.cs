namespace WFM.Views
{
    partial class Employees
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 450);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.panel2.Controls.Add(this.guna2ImageButton2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(579, 73);
            this.panel2.TabIndex = 0;
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.CheckedState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2ImageButton2.HoverState.Image = global::WFM.Properties.Resources.add_user_huver;
            this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.HoverState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.Image = global::WFM.Properties.Resources.add_user;
            this.guna2ImageButton2.ImageRotate = 0F;
            this.guna2ImageButton2.Location = new System.Drawing.Point(492, 0);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.PressedState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.Size = new System.Drawing.Size(87, 73);
            this.guna2ImageButton2.TabIndex = 4;
            this.guna2ImageButton2.Click += new System.EventHandler(this.guna2ImageButton2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(579, 377);
            this.panel3.TabIndex = 0;
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Employees";
            this.Size = new System.Drawing.Size(579, 450);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private System.Windows.Forms.Panel panel3;
    }
}
