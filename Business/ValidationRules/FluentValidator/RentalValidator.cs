using System;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidator
{
    public class RentalValidator :AbstractValidator<Rentals>
    {
        public RentalValidator()
        {
            RuleFor(r => r.carid).NotEmpty();
            RuleFor(r => r.customerid).NotEmpty();
            RuleFor(r => r.rentdate).NotEmpty();
            RuleFor(r => r.returndate).NotNull();
        }
    }
}
