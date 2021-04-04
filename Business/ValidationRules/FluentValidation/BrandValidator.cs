using Entities.Concrete;
using FluentValidation;

namespace Business.DependencyResolvers.FluentValidation
{
    public class BrandValidator : AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            
        }
    }
}