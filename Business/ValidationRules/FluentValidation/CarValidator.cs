using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.BrandId).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThanOrEqualTo(200).When(c=>c.CarId==2);
            RuleFor(c => c.DailyPrice).GreaterThan(100);
            RuleFor(c => c.Descriptions).MinimumLength(8);
        }
        
    }
}
