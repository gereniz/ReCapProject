using System;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidator
{
    public class UserValidator : AbstractValidator<Users>
    {
        public UserValidator()
        {
            RuleFor(u => u.name).NotEmpty();
            RuleFor(u => u.surname).NotEmpty();
            RuleFor(u => u.password).NotEmpty();
            RuleFor(u => u.email).EmailAddress();
        }
    }
}
