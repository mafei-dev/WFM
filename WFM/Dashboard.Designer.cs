namespace WFM
{
    partial class Dashboard
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
            this.PnlDashboard = new System.Windows.Forms.Panel();
            this.LblDashboard = new System.Windows.Forms.Label();
            this.LblEmployee = new System.Windows.Forms.Label();
            this.LblProjects = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.panel1.Controls.Add(this.LblEmployee);
            this.panel1.Controls.Add(this.LblProjects);
            this.panel1.Controls.Add(this.LblDashboard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 450);
            this.panel1.TabIndex = 0;
            // 
            // PnlDashboard
            // 
            this.PnlDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.PnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlDashboard.Location = new System.Drawing.Point(114, 0);
            this.PnlDashboard.Name = "PnlDashboard";
            this.PnlDashboard.Size = new System.Drawing.Size(686, 450);
            this.PnlDashboard.TabIndex = 1;
            this.PnlDashboard.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlDashboard_Paint);
            // 
            // LblDashboard
            // 
            this.LblDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LblDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDashboard.ForeColor = System.Drawing.Color.White;
            this.LblDashboard.Image = global::WFM.Properties.Resources.chart1;
            this.LblDashboard.Location = new System.Drawing.Point(0, 0);
            this.LblDashboard.Name = "LblDashboard";
            this.LblDashboard.Size = new System.Drawing.Size(114, 102);
            this.LblDashboard.TabIndex = 0;
            this.LblDashboard.Text = "Dashboard";
            this.LblDashboard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LblDashboard.Click += new System.EventHandler(this.LblDashboard_Click);
            // 
            // LblEmployee
            // 
            this.LblEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LblEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmployee.ForeColor = System.Drawing.Color.White;
            this.LblEmployee.Image = global::WFM.Properties.Resources.emp;
            this.LblEmployee.Location = new System.Drawing.Point(0, 204);
            this.LblEmployee.Name = "LblEmployee";
            this.LblEmployee.Size = new System.Drawing.Size(114, 102);
            this.LblEmployee.TabIndex = 2;
            this.LblEmployee.Text = "Employees";
            this.LblEmployee.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LblEmployee.Click += new System.EventHandler(this.LblEmployee_Click);
            // 
            // LblProjects
            // 
            this.LblProjects.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblProjects.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LblProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProjects.ForeColor = System.Drawing.Color.White;
            this.LblProjects.Image = global::WFM.Properties.Resources.projects;
            this.LblProjects.Location = new System.Drawing.Point(0, 102);
            this.LblProjects.Name = "LblProjects";
            this.LblProjects.Size = new System.Drawing.Size(114, 102);
            this.LblProjects.TabIndex = 1;
            this.LblProjects.Text = "Projects";
            this.LblProjects.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LblProjects.Click += new System.EventHandler(this.LblProjects_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PnlDashboard);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label LblDashboard;
        private System.Windows.Forms.Label LblEmployee;
        private System.Windows.Forms.Label LblProjects;

        private System.Windows.Forms.Panel PnlDashboard;

        #endregion

        private System.Windows.Forms.Panel panel1;
    }
}

