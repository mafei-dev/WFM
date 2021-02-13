using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WFM.Controller;
using WFM.Entity;

namespace WFM.Views
{
    public partial class Projects : UserControl
    {
        private ProjectsController _projectsController;
        private string name;

        public Projects(string name)
        {
            InitializeComponent();
            LoadAllProjects();
            this.name = name;
        }
        private List<ProjectWithClient> projects;
        private void LoadAllProjects()
        {
            dgAllProjects.Update();
            dgAllProjects.Rows.Clear();
            dgAllProjects.Refresh();

            _projectsController = new ProjectsController();
            projects = new List<ProjectWithClient>();
            projects = _projectsController.GetAllProjects();
            if (projects.Count > 0)
            {
                
                dgAllProjects.ColumnCount = 7;
                // dgAllProjects.DataSource =
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.HeaderText = "#Action";
                btn.Text = "Update";
                btn.Name = "btnUpdate";
                btn.UseColumnTextForButtonValue = true;
                // btn.Width = 55;
                dgAllProjects.Columns.Add(btn);


          
                dgAllProjects.Columns[0].Name = "Project Name";
                dgAllProjects.Columns[1].Name = "Project Note";
                dgAllProjects.Columns[2].Name = "Status";
                dgAllProjects.Columns[3].Name = "Start Date";
                dgAllProjects.Columns[4].Name = "End Date";
                dgAllProjects.Columns[5].Name = "Estimated End Date";
                dgAllProjects.Columns[6].Name = "Client";


                foreach (ProjectWithClient project in projects)
                {
                    string[] row =
                    {
                        project.Project_Name,
                        project.Project_Note,
                        project.Status,
                        project.Start_Date.ToString("M/d/yy"),
                        project.End_Date.ToString("M/d/yy"),
                        project.Estimated_End_Date.ToString("M/d/yy"),
                        $"{project.First_Name} {project.Last_Name}",
                    };
                    dgAllProjects.Rows.Add(row);
                }
                
                dgAllProjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                dgAllProjects.DataSource = default;
            }

            
        }

        private void lblAddNewProject_Click(object sender, EventArgs e)
        {
            AddNewProject addNewProject = new AddNewProject();
            addNewProject.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dgAllProjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                ProjectWithClient selectedProject = projects[e.RowIndex];
                ProjectManagementOptionPane projectManagementOptionPane = new ProjectManagementOptionPane(selectedProject);
                projectManagementOptionPane.ShowDialog(this);
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddNewProject addNewProject = new AddNewProject();
            addNewProject.ShowDialog(this);
            LoadAllProjects();
        }

        private void lblRefresh_Click(object sender, EventArgs e)
        {
            LoadAllProjects();
        }

        private void btnAddIncome_Click(object sender, EventArgs e)
        {
           
        }
    }
}

//todo : set project object
// AssignEmployee assignEmployee = new AssignEmployee("ef61bfa9-0be4-4a29-9412-170deabff2f9");
// assignEmployee.ShowDialog(this);