using System;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidator
{
    public class CustomerValidator : AbstractValidator<Customers>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.userid).NotEmpty();
        }
    }
}
