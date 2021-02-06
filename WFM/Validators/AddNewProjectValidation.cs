using System;
using FluentValidation;
using WFM.Entity;

namespace WFM.Validators
{
    public class AddNewProjectValidation : AbstractValidator<Project>
    {
        public AddNewProjectValidation()
        {
            RuleFor(project => project.Project_Name)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .WithMessage("Project name Can't be Empty.");

            RuleFor(project => project.Status)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .WithMessage("Project status Can't be Empty.");

            RuleFor(project => project.Cost)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .Must(CheckCost)
                .WithMessage("Cost value is incorrect.");



            //todo : validate date
        }

        protected bool CheckStartDateAndEstimatedEndDate(DateTime Estimated_End_Date, DateTime EndDate)
        {
            return true;
        }

        protected bool CheckCost(string cost) {

            try
            {
                Convert.ToDecimal(cost);
                return true;

            }
            catch {
                return false;
            }
        
        }
    }
}