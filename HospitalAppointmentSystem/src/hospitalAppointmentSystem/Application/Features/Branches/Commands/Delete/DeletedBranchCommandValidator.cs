using FluentValidation;

namespace Application.Features.Branches.Commands.Delete;

public class DeleteBranchCommandValidator : AbstractValidator<DeleteBranchCommand>
{
    public DeleteBranchCommandValidator()
    {
<<<<<<< Updated upstream
        RuleFor(c => c.Id).NotEmpty().WithMessage("Id bo� olamaz");
=======
        RuleFor(c => c.Id).NotEmpty().WithMessage("Id alan� bo� olamaz.");
>>>>>>> Stashed changes
    }
}