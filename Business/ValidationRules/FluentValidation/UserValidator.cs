using Entities.Concrete;
using FluentValidation;

namespace Business.DependencyResolvers.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            
        }
    }
}