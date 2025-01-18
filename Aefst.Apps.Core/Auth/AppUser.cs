using Microsoft.AspNetCore.Identity;

namespace Aefst.Apps.Core.Auth
{
    public class AppUser : IdentityUser
    {
        public string Noms { get; set; }
        public string Prenoms { get; set; }
        public string Genre { get; set; }
        public DateOnly DateDeNaissance { get; set; }
        public DateOnly PremiereAnneeFst { get; set; }
    }
}
