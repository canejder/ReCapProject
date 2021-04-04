using Entities.Concrete;
using FluentValidation;

namespace Business.DependencyResolvers.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            
        }   
    }
}