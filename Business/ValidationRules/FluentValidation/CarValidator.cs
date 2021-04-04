using System;
using Entities.Concrete;
using FluentValidation;

namespace Business.DependencyResolvers.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.CarName).MinimumLength(3);
            RuleFor(c => c.DailyPrice).GreaterThanOrEqualTo(150);
            RuleFor(c => c.ModelYear).GreaterThanOrEqualTo(new DateTime(1950,01,01));
            RuleFor(c => c.ModelYear).LessThanOrEqualTo(DateTime.Now);
        }
    }
}