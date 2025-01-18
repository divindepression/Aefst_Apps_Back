using Aefst.Apps.Core.Abstractions;

namespace Aefst.Apps.Core.Models
{
    public class Adresse : Entite
    {
        public Adresse()
        {
        }

        public Adresse(Guid id) : base(id)
        {
        }

        public int NumeroRue { get; set; }
        public string Rue { get; set; }
        public string Quartier { get; set; }
        public string Arrondissement { get; set; }
        public string Ville { get; set; }
        public string Pays { get; set; }
    }
}
