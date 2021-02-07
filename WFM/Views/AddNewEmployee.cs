using System;
using System.ComponentModel;
using System.Windows.Forms;
using FluentValidation.Results;
using WFM.Enity;
using WFM.Controller;
using WFM.Models;
using WFM.Properties;
using WFM.Validators;

namespace WFM.Views
{
    public partial class AddNewEmployee : Form
    {
        private User _user;
        private IEmployeeService _employeeService = new EmployeeService();

        public AddNewEmployee()
        {
            InitializeComponent();
            cboxUserType.SelectedIndex = 0;
        }

        EmployeeValidator _employeeValidator = new EmployeeValidator();
        AdminValidator _adminValidator = new AdminValidator();

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cboxUserType.SelectedItem.ToString().Equals("Employee User"))
            {
                _user = new Employee();
                _user.User_Type =2;
                _user.First_Name = txtFName.Text;
                _user.Last_Name = txtLName.Text;
                _user.Address = txtAddress.Text;
                _user.Birthday = dpBirthday.Value.Date;
                _user.NIC = txtNIC.Text;
                _user.Gender = rbtnMale.Checked ? rbtnMale.Text : _user.Gender;
                _user.Gender = rbtnFemale.Checked ? rbtnFemale.Text : _user.Gender;

                errorFName.Clear();
                ValidationResult validationResult = _employeeValidator.Validate((Employee)_user);
                if (!validationResult.IsValid)
                {
                    foreach (ValidationFailure validationResultError in validationResult.Errors)
                    {
                        if (validationResultError.PropertyName.Equals(nameof(_user.First_Name)))
                        {
                            errorFName.SetError(txtFName, validationResultError.ErrorMessage);
                        }
                        else if (validationResultError.PropertyName.Equals(nameof(_user.Last_Name)))
                        {
                            errorFName.SetError(txtLName, validationResultError.ErrorMessage);
                        }
                        else if (validationResultError.PropertyName.Equals(nameof(_user.Address)))
                        {
                            errorFName.SetError(txtAddress, validationResultError.ErrorMessage);
                        }
                        else if (validationResultError.PropertyName.Equals(nameof(_user.NIC)))
                        {
                            errorFName.SetError(txtNIC, validationResultError.ErrorMessage);
                        }

                        else if (validationResultError.PropertyName.Equals(nameof(_user.Birthday)))
                        {
                            errorFName.SetError(dpBirthday, validationResultError.ErrorMessage);
                        }

                        else if (validationResultError.PropertyName.Equals(nameof(_user.User_Type)))
                        {
                            errorFName.SetError(cboxUserType, validationResultError.ErrorMessage);
                        }
                    }
                }
                else
                {
                    if (_employeeService.AddNewEmployee(_user, StaticResource.UseType.EMPLOYEE_USER) > 0)
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
            else if (cboxUserType.SelectedItem.ToString().Equals("Admin User"))
            {
                _user = new AdminUser();
                _user.User_Type = 1;
                _user.First_Name = txtFName.Text;
                _user.Last_Name = txtLName.Text;
                _user.Address = txtAddress.Text;
                _user.Birthday = dpBirthday.Value.Date;
                _user.NIC = txtNIC.Text;
                _user.Gender = rbtnMale.Checked ? rbtnMale.Text : _user.Gender;
                _user.Gender = rbtnFemale.Checked ? rbtnFemale.Text : _user.Gender;


                errorFName.Clear();
                ValidationResult validationResult = _adminValidator.Validate((AdminUser)_user);
                if (!validationResult.IsValid)
                {
                    foreach (ValidationFailure validationResultError in validationResult.Errors)
                    {
                        if (validationResultError.PropertyName.Equals(nameof(_user.First_Name)))
                        {
                            errorFName.SetError(txtFName, validationResultError.ErrorMessage);
                        }
                        else if (validationResultError.PropertyName.Equals(nameof(_user.Last_Name)))
                        {
                            errorFName.SetError(txtLName, validationResultError.ErrorMessage);
                        }
                        else if (validationResultError.PropertyName.Equals(nameof(_user.Address)))
                        {
                            errorFName.SetError(txtAddress, validationResultError.ErrorMessage);
                        }
                        else if (validationResultError.PropertyName.Equals(nameof(_user.NIC)))
                        {
                            errorFName.SetError(txtNIC, validationResultError.ErrorMessage);
                        }

                        else if (validationResultError.PropertyName.Equals(nameof(_user.Birthday)))
                        {
                            errorFName.SetError(dpBirthday, validationResultError.ErrorMessage);
                        }

                        else if (validationResultError.PropertyName.Equals(nameof(_user.User_Type)))
                        {
                            errorFName.SetError(cboxUserType, validationResultError.ErrorMessage);
                        }
                    }
                }
                else
                {
                    if (_employeeService.AddNewEmployee(_user, StaticResource.UseType.ADMIN_USER) > 0)
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
        }

        private void clearForm()
        {
            txtFName.ResetText();
            txtLName.ResetText();
            txtAddress.ResetText();
            dpBirthday.ResetText();
            txtNIC.ResetText();
            rbtnMale.Checked = true;
            errorFName.Clear();
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void dpBirthday_ValueChanged(object sender, EventArgs e)
        {
        }

        private void txtNIC_TextChanged(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void cboxUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxUserType.SelectedItem.ToString().Equals("Admin User"))
            {
                lblUserId.Visible = false;
                txtUserID.Visible = false;
            }
            else if (cboxUserType.SelectedItem.ToString().Equals("Employee User"))
            {
                lblUserId.Visible = true;
                txtUserID.Visible = true;
            }
        }
    }
}