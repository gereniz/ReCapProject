using System;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidator
{
    public class CarValidator : AbstractValidator<Cars>
    {
        public CarValidator()
        {
            RuleFor(c => c.dailyprice).GreaterThan(0);
            RuleFor(c => c.colorid).NotEmpty();
            RuleFor(c => c.brandid).NotEmpty();
        }
    }
}
