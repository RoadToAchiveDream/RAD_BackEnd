﻿using FluentValidation;
using RAD_BackEnd.DTOs.Notes;

namespace RAD_BackEnd.WebApi.Validators.Notes;

public class NoteCreateModelValidator : AbstractValidator<NoteCreateModel>
{
    public NoteCreateModelValidator()
    {
        RuleFor(note => note.Title)
            .NotNull()
            .WithMessage(note => $"{nameof(note.Title)} is not specified");

        RuleFor(note => note.Content)
            .NotEmpty()
            .WithMessage(note => $"{nameof(note.Content)} is not specified");
    }
}