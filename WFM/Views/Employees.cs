using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WFM.Controller;
using WFM.Enity;
using WFM.Properties;

namespace WFM.Views
{
    public partial class Employees : UserControl
    {
        private IEmployeesController _employeesController;

        public Employees()
        {
            InitializeComponent();
            LoadTable();
        }

        private void btnUpdate(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            AddNewEmployee addNewEmployee = new AddNewEmployee();
            addNewEmployee.ShowDialog(this);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddAttendance addAttendance = new AddAttendance();
            addAttendance.ShowDialog(this);
        }

        private void dgAllUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show($"{e.RowIndex}");
/*            if (e.ColumnIndex == 3) 
            {
                
            }*/
        }

        private void LoadTable()
        {
            dgAllUsers.ColumnCount = 8;
            dgAllUsers.Columns[0].Name = "User Type";
            dgAllUsers.Columns[1].Name = "EMP Id";
            dgAllUsers.Columns[2].Name = "First Name";
            dgAllUsers.Columns[3].Name = "Last Name";
            dgAllUsers.Columns[4].Name = "Address";
            dgAllUsers.Columns[5].Name = "NIC";
            dgAllUsers.Columns[6].Name = "Birthday";
            dgAllUsers.Columns[7].Name = "Gender";

            _employeesController = new EmployeesController();
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "#Action";
            btn.Text = "Update";
            btn.Name = "btnUpdate";
            btn.UseColumnTextForButtonValue = true;
            dgAllUsers.Columns.Add(btn);

            DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
            btn1.HeaderText = "#Action";
            btn1.Text = "More";
            btn1.Name = "btnMore";
            btn1.UseColumnTextForButtonValue = true;
            dgAllUsers.Columns.Add(btn1);
            try
            {
                List<User> allUsers = _employeesController.GetAllUsers();
                foreach (User user in allUsers)
                {
                    

                    string type = null;
                    if (user.User_Type == (int) StaticResource.UseType.ADMIN_USER)
                    {
                        type = StaticResource.UseTypes.ADMIN_USER;
                    }
                    else if (user.User_Type == (int) StaticResource.UseType.EMPLOYEE_USER)
                    {
                        type = StaticResource.UseTypes.EMPLOYEE_USER;
                    }

                    string[] row =
                    {
                        type,
                        user.EMP_Id,
                        user.First_Name,
                        user.Last_Name,
                        user.Address,
                        user.NIC,
                        user.Birthday.ToString("M/d/yy"),
                        user.Gender,
                    };
                    dgAllUsers.Rows.Add(row);
                }
            }
            catch (System.Exception e)
            {
                throw;
            }
            dgAllUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}