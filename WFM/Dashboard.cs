using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WFM;
using WFM.Views;

namespace WFM
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void licensing1_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            // throw new System.NotImplementedException();
            //Login login = new Login();
            // login.Show();
        }

        public void changePanel(string activePanel)
        {
        }


        private void LblDashboard_Click(object sender, EventArgs e)
        {
            Projects projects = new Projects(DateTime.Now.ToString());
            projects.Dock = DockStyle.Fill;
            PnlDashboard.Controls.Add(projects);
            
        }
    }
}