using FluentValidation;

namespace Aefst.Apps.Application.UseCase.AdresseUseCase.AddAdresse
{
    public class AddAdresseValidator : AbstractValidator<AddAdresseCommand>
    {
        public AddAdresseValidator() 
        {
            RuleFor(x => x.Quartier).NotNull().NotEmpty();
        }
    }
}
