namespace Aefst.Apps.Core.Abstractions
{
    public abstract class Entite
    {
        protected Entite(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}
