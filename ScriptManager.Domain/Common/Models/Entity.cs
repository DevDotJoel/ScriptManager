namespace ScriptManager.Domain.Common.Models
{

    public abstract class Entity<T>
    {
        public T Id { get; protected set; }
    }
}