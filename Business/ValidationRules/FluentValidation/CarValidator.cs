﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.Name).NotEmpty();
            RuleFor(c => c.Name).MinimumLength(2);
            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThan(0);

            //RuleFor(c => c.Name).Must(StartWithA).WithMessage("Araba isimleri A harfi ile başlamalı!"); eğer kendin bir şeyler yazmak istersen....
        }

        //private bool StartWithA(string name)
        //{
        //    return name.StartsWith("A");
        //}
    }
}
