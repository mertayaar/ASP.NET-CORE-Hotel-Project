using System;
using FluentValidation;
using HotelProject.WebUI.Areas.Admin.Dtos.GuestDto;

namespace HotelProject.WebUI.Areas.Admin.ValidationRules.Guest
{
	public class UpdateGuestValidator : AbstractValidator<UpdateGuestDto>
	{
		public UpdateGuestValidator()
		{
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name is required.")
                .MinimumLength(2).WithMessage("Name should be at least 2 character.")
                .MaximumLength(20).WithMessage("Name should not exceed 20 characters.");


            RuleFor(x => x.Surname)
                .NotEmpty().WithMessage("Surname is required.")
                .MinimumLength(2).WithMessage("Surname should be at least 2 character.")
                .MaximumLength(20).WithMessage("Surname should not exceed 20 characters.");


            RuleFor(x => x.City)
                .NotEmpty().WithMessage("City is required.")
                .MinimumLength(2).WithMessage("City should be at least 2 character.")
                .MaximumLength(20).WithMessage("City should not exceed 20 characters.");
        }
	}
}

