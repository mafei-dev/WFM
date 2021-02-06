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

        private void button1_Click(object sender, EventArgs e)
        {
            //todo : set project object
            AssignEmployee assignEmployee = new AssignEmployee("ef61bfa9-0be4-4a29-9412-170deabff2f9");
            assignEmployee.ShowDialog(this);
        }
    }
}