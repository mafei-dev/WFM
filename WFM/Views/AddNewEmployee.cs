using System;
using System.ComponentModel;
using System.Windows.Forms;
using FluentValidation.Results;
using WFM.Models;
using WFM.Services;
using WFM.Validators;

namespace WFM.Views
{
    public partial class AddNewEmployee : Form
    {
        private Employee _employee = new Employee();
        private IEmployeeService _employeeService = new EmployeeService();

        public AddNewEmployee()
        {
            InitializeComponent();
        }

        EmployeeValidator _employeeValidator = new EmployeeValidator();

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            _employee.First_Name = txtFName.Text;
            _employee.Last_Name = txtLName.Text;
            _employee.Address = txtAddress.Text;
            _employee.Birthday = dpBirthday.Text;
            _employee.NIC = txtNIC.Text;

            ValidationResult validationResult = _employeeValidator.Validate(_employee);
            if (!validationResult.IsValid)
            {
                foreach (ValidationFailure validationResultError in validationResult.Errors)
                {
                    if (validationResultError.PropertyName.Equals(nameof(_employee.First_Name)))
                    {
                        errorFName.SetError(txtFName, validationResultError.ErrorMessage);
                    }
                    else if (validationResultError.PropertyName.Equals(nameof(_employee.Last_Name)))
                    {
                        errorFName.SetError(txtLName, validationResultError.ErrorMessage);
                    }
                    else if (validationResultError.PropertyName.Equals(nameof(_employee.Address)))
                    {
                        errorFName.SetError(txtAddress, validationResultError.ErrorMessage);
                    }
                    else if (validationResultError.PropertyName.Equals(nameof(_employee.NIC)))
                    {
                        errorFName.SetError(txtNIC, validationResultError.ErrorMessage);
                    }
                }
            }
            else
            {
                if (_employeeService.AddNewEmployee(_employee) > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Successfully Added!\nDo you want to add more..?",
                        "Result",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        clearForm();
                    }
                    else
                    {
                        Close();
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Added Failed!", "Result",
                        MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (dialogResult == DialogResult.Cancel)
                    {
                        Close();
                    }
                }
            }
        }

        private void clearForm()
        {
            txtFName.ResetText();
            txtLName.ResetText();
            txtAddress.ResetText();
            dpBirthday.ResetText();
            txtNIC.ResetText();
        }


        private void btnSubmit_Validating(object sender, CancelEventArgs e)
        {
        }

        private void txtFName_Enter(object sender, EventArgs e)
        {
            errorFName.SetError(txtFName, null);
        }

        private void txtLName_Enter(object sender, EventArgs e)
        {
            errorFName.SetError(txtLName, null);
        }

        private void txtNIC_Enter(object sender, EventArgs e)
        {
            errorFName.SetError(txtNIC, null);
        }

        private void txtAddress_Enter(object sender, EventArgs e)
        {
            errorFName.SetError(txtAddress, null);
        }

        private void dpBirthday_Enter(object sender, EventArgs e)
        {
            errorFName.SetError(dpBirthday, null);
        }
    }
}