﻿using FluentValidation;
using RAD_BackEnd.DTOs.Events;

namespace RAD_BackEnd.WebApi.Validators.Events;

public class EventCreateModelValidator : AbstractValidator<EventCreateModel>
{
    public EventCreateModelValidator()
    {
        RuleFor(@event => @event.Title)
            .NotNull()
            .WithMessage(@event => $"{nameof(@event.Title)} is not specified");

        RuleFor(@event => @event.Description)
            .NotEmpty()
            .WithMessage(@event => $"{nameof(@event.Description)} is not specified");
    }
}