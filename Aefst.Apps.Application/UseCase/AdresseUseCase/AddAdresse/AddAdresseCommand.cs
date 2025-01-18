using Aefst.Apps.Core.Models;
using MediatR;

namespace Aefst.Apps.Application.UseCase.AdresseUseCase.AddAdresse
{
    public record AddAdresseCommand
        (
        int NumeroRue,
        string Rue,
        string Quartier,
        string Arrondissement,
        string Ville,
        string Pays
        ) : IRequest<Adresse>;
}
