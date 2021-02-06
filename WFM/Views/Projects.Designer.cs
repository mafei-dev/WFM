namespace WFM.Views
{
    partial class Projects
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAddNewProject = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Controls.Add(this.lblAddNewProject);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(699, 73);
            this.panel2.TabIndex = 1;
            // 
            // lblAddNewProject
            // 
            this.lblAddNewProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAddNewProject.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblAddNewProject.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblAddNewProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewProject.ForeColor = System.Drawing.Color.White;
            this.lblAddNewProject.Image = global::WFM.Properties.Resources.projects;
            this.lblAddNewProject.Location = new System.Drawing.Point(629, 0);
            this.lblAddNewProject.Name = "lblAddNewProject";
            this.lblAddNewProject.Size = new System.Drawing.Size(70, 73);
            this.lblAddNewProject.TabIndex = 2;
            this.lblAddNewProject.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblAddNewProject.Click += new System.EventHandler(this.lblAddNewProject_Click);
            // 
            // Projects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.panel2);
            this.Name = "Projects";
            this.Size = new System.Drawing.Size(699, 449);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblAddNewProject;
    }
}
