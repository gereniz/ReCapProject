using System;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidator
{
    public class ColorValidator : AbstractValidator<Colors>
    {
        public ColorValidator()
        {
            RuleFor(c => c.colorname).NotEmpty();
        }
    }
}
