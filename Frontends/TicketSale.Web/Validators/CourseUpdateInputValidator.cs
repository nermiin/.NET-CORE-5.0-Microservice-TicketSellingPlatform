﻿using FluentValidation;
using TicketSale.Web.Models.Catalogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSale.Web.Validators
{
    public class TicketUpdateInputValidator : AbstractValidator<TicketUpdateInput>
    {
        public TicketUpdateInputValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("isim alanı boş olamaz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("açıklama alanı boş olamaz");
            RuleFor(x => x.Feature.Duration).InclusiveBetween(1, int.MaxValue).WithMessage("süre alanı boş olamaz");

            RuleFor(x => x.Price).NotEmpty().WithMessage("fiyat alanı boş olamaz").ScalePrecision(2, 6).WithMessage("hatalı para formatı");
        }
    }
}