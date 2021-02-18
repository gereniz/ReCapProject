using System;
using FluentValidation;

namespace Core.CrossCuttingConcerns.Validator
{
    public static class ValidationTool
    {
        public static void Validator(IValidator validator,object entity)
        {
            var context = new ValidationContext<object>(entity);
            var result = validator.Validate(context);
            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
