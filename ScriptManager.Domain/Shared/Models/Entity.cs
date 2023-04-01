namespace ScriptManager.Domain.Shared.Models
{

    public abstract class Entity<T>
    {
        public T Id { get; protected set; }
    }
}