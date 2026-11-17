namespace Domain.Entities.Common
{
    public class BaseEntity
    {
        public Guid Id { get; private init; } = Guid.CreateVersion7();

        public DateTime CreatedAt { get; private init; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; }  
    }
}
