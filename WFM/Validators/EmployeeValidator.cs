using FluentValidation;
using WFM.Models;

namespace WFM.Validators
{
    public class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(employee => employee.First_Name)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .WithMessage("First Name Can't be Empty.");

            RuleFor(employee => employee.Last_Name)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .WithMessage("Last Name Can't be Empty.");

            RuleFor(employee => employee.Address)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .WithMessage("Address Name Can't be Empty.");

            RuleFor(employee => employee.NIC)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .WithMessage("NIC Can't be Empty.");
            
        }
    }
}