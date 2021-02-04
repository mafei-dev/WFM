using System;
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


            RuleFor(employee => employee.Birthday)
                .Must(CheckBirthday).WithMessage("Birthday must be before today.");

        }

        protected bool CheckBirthday(DateTime birthday)
        {
            Console.WriteLine("birthday {0}, today {1}",arg0:birthday,arg1:DateTime.Today);
            int dateDiff = DateTime.Compare(DateTime.Today, birthday);
            Console.WriteLine("dateDiff > {0}",arg0: dateDiff);
            if (dateDiff==0 || dateDiff < 0 )
            {
                return false;
            }
            return true;
        }
    }
}