using Entities.Concrete;
using FluentValidation;

namespace Business.DependencyResolvers.FluentValidation
{
    public class ColorValidator : AbstractValidator<Color>
    {
        public ColorValidator()
        {
            
        }
    }
}