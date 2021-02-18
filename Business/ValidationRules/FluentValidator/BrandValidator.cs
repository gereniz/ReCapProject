using System;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidator
{
    public class BrandValidator : AbstractValidator<Brands>
    {
        public BrandValidator()
        {
            RuleFor(b => b.brandname).NotEmpty();
            RuleFor(b => b.brandname).MinimumLength(2);
        }
    }
}
