using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WFM.Models;
using WFM.Presenters;
using WFM.Repository;
using WFM.Services;

namespace WFM.Views
{
    public partial class AddNewEmployee : Form
    {
        private User _user = new User();
        private Employee _employee = new Employee();
        private IEmployeeService _employeeService = new EmployeeService();

        public AddNewEmployee()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("button1_Click");
            List<Employee> searchEmpByData = _employeeService.SearchEMPByData(txtFName.Text);
            foreach (var employee in searchEmpByData)
            {
                Console.WriteLine("employee " + employee.First_Name);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            _employee.First_Name = txtFName.Text;
            _employee.Last_Name = txtLName.Text;
            _employee.Address = txtAddress.Text;
            _employee.Birthday = dpBirthday.Text;
            _employee.NIC = txtNIC.Text;
            if (_employeeService.AddNewEmployee(_employee)>0)
            {
                MessageBox.Show("Added Successfully!", "Success");
            }
        }
    }
}