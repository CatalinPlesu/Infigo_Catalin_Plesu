using System.IO.Enumeration;
using CMSPlus.Domain.Entities;
using CMSPlus.Domain.Interfaces;
using CMSPlus.Domain.Models.TopicModels;
using FluentValidation;

namespace CMSPlus.Presentation.Validations;

public class CommentCreateModelValidator:AbstractValidator<TopicDetailsModel>
{
    public CommentCreateModelValidator()
    {
        RuleFor(x => x.CreateComment.FullName).NotEmpty().WithMessage("Full Name is required.");
        RuleFor(x => x.CreateComment.Comment).NotEmpty().WithMessage("Comment is required.");
    }
}