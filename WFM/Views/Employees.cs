using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WFM.Views
{
    public partial class Employees : UserControl
    {
        public Employees()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            AddNewEmployee addNewEmployee = new AddNewEmployee();
            addNewEmployee.ShowDialog(this);
        }
    }
}
