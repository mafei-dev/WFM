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
    public partial class Projects : UserControl
    {
        private string name;

        public Projects(string name)
        {
            InitializeComponent();
            this.name = name;
        }

        private void lblAddNewProject_Click(object sender, EventArgs e)
        {
            AddNewProject addNewProject = new AddNewProject();
            addNewProject.ShowDialog(this);
        }
    }
}