using Aefst.Apps.Core.Abstractions;

namespace Aefst.Apps.Core.Models
{
    public class Adhesion : Entite
    {
        public Adhesion(Guid id) : base(id)
        {
        }

        public string Noms { get; set; }
        public string Prenoms { get; set; }
        public DateOnly DateDeNaissance { get; set; }
        public string LieuDeNaissance { get; set; }
        public Adresse Adresse { get; set; }
        public string NiveauEtude { get; set; }
        public string Section { get; set; }
        public DateTime DateAdhesion { get; set; }
        public string Telephone { get; set; }
        public string? Email { get; set; }
        public Tuteur Tuteur { get; set; }
    }
}
