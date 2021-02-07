namespace WFM.Views
{
    partial class Metrics
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            lblTotalEmp = new System.Windows.Forms.Label();
            lblTotalAssets = new System.Windows.Forms.Label();
            lblTotalProject = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.16049F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.83951F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(723, 486);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Controls.Add(lblTotalEmp, 1, 0);
            this.tableLayoutPanel2.Controls.Add(lblTotalAssets, 2, 0);
            this.tableLayoutPanel2.Controls.Add(lblTotalProject, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(717, 126);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblTotalEmp
            // 
            lblTotalEmp.AutoSize = true;
            lblTotalEmp.Dock = System.Windows.Forms.DockStyle.Fill;
            lblTotalEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTotalEmp.ForeColor = System.Drawing.Color.Yellow;
            lblTotalEmp.Location = new System.Drawing.Point(242, 0);
            lblTotalEmp.Name = "lblTotalEmp";
            lblTotalEmp.Size = new System.Drawing.Size(233, 126);
            lblTotalEmp.TabIndex = 1;
            lblTotalEmp.Text = "label1";
            lblTotalEmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalAssets
            // 
            lblTotalAssets.AutoSize = true;
            lblTotalAssets.Dock = System.Windows.Forms.DockStyle.Fill;
            lblTotalAssets.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTotalAssets.ForeColor = System.Drawing.Color.Yellow;
            lblTotalAssets.Location = new System.Drawing.Point(481, 0);
            lblTotalAssets.Name = "lblTotalAssets";
            lblTotalAssets.Size = new System.Drawing.Size(233, 126);
            lblTotalAssets.TabIndex = 1;
            lblTotalAssets.Text = "label1";
            lblTotalAssets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalProject
            // 
            lblTotalProject.AutoSize = true;
            lblTotalProject.Dock = System.Windows.Forms.DockStyle.Fill;
            lblTotalProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTotalProject.ForeColor = System.Drawing.Color.Yellow;
            lblTotalProject.Location = new System.Drawing.Point(3, 0);
            lblTotalProject.Name = "lblTotalProject";
            lblTotalProject.Size = new System.Drawing.Size(233, 126);
            lblTotalProject.TabIndex = 1;
            lblTotalProject.Text = "label1";
            lblTotalProject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblTotalProject.Click += new System.EventHandler(this.lblTotalProject_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "label1";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Metrics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Metrics";
            this.Size = new System.Drawing.Size(723, 486);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public static System.Windows.Forms.Label lblTotalEmp;
        public static System.Windows.Forms.Label lblTotalAssets;
        public static System.Windows.Forms.Label lblTotalProject;
        private System.Windows.Forms.Label label4;
    }
}
