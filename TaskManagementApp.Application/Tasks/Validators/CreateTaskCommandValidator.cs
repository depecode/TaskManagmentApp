using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManagementApp.Application.Tasks.Commands;

namespace TaskManagementApp.Application.Tasks.Validators
{
    public class CreateTaskCommandValidator : AbstractValidator<CreateTaskCommand>
    {
        public CreateTaskCommandValidator()
        {
            RuleFor(t => t.Name).NotEmpty();
            RuleFor(t => t.Description).NotEmpty();
            RuleFor(t => t.Status).NotNull();
            RuleFor(t => t.DueDate).NotNull();
        }
    }
}
