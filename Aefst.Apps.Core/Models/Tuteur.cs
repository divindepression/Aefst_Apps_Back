using Aefst.Apps.Core.Abstractions;

namespace Aefst.Apps.Core.Models
{
    public class Tuteur : Entite
    {
        public Tuteur(Guid id) : base(id)
        {
        }

        public string NomComplet { get; set; }
        public string Telephone { get; set; }
        public string? Email { get; set; }
        public Guid EtudiantId { get; set; }
    }
}
