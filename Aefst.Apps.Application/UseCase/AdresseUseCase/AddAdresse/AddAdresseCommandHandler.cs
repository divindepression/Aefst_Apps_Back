using Aefst.Apps.Core.Interfaces;
using Aefst.Apps.Core.Models;
using MediatR;

namespace Aefst.Apps.Application.UseCase.AdresseUseCase.AddAdresse
{
    public class AddAdresseCommandHandler : IRequestHandler<AddAdresseCommand, Adresse>
    {
        private readonly IAdresseRepository _repository;

        public AddAdresseCommandHandler(IAdresseRepository repository)
        {
            _repository = repository;
        }

        public async Task<Adresse> Handle(AddAdresseCommand request, CancellationToken cancellationToken)
        {
            var adresse = new Adresse()
            {
                NumeroRue = request.NumeroRue,
                Rue = request.Rue,
                Quartier = request.Quartier,
                Arrondissement = request.Arrondissement,
                Ville = request.Ville,
                Pays = request.Pays
            };
            return await _repository.Create(adresse);
        }
    }
}
