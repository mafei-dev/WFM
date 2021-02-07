using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WFM.Controller;

namespace WFM.Views
{
    public partial class Metrics : UserControl
    {

        public Metrics()
        {
            InitializeComponent();
            loadToatlDetail();
        }

        public static void loadToatlDetail() 
        {
            MetricsController metricsController= new MetricsController();
            Models.TotalDetail totalDetail = metricsController.GetTotalDetails();
            lblTotalProject.Text = $"Toatl Project \n {totalDetail.TotalProject}";
            lblTotalEmp.Text = $"Total Employees \n {totalDetail.TotalEmployees}";
            lblTotalAssets.Text = $"Total Assets \n {totalDetail.TotalAssets}";
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("tabControl1_Click");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalProject_Click(object sender, EventArgs e)
        {

        }
    }
}
