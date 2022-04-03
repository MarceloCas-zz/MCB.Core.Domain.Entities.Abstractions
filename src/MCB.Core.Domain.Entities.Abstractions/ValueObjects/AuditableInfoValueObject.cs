namespace MCB.Core.Domain.Entities.Abstractions.ValueObjects
{
    public record AuditableInfoValueObject
    {
        // Properties
        public string CreatedBy { get; }
        public DateTimeOffset CreatedAt { get; }
        public string UpdatedBy { get; }
        public DateTimeOffset UpdatedAt { get; }

        // Constructors
        public AuditableInfoValueObject(
            string createdBy,
            DateTimeOffset createdAt,
            string updatedBy,
            DateTimeOffset updatedAt
        )
        {
            CreatedBy = createdBy;
            CreatedAt = createdAt;
            UpdatedBy = updatedBy;
            UpdatedAt = updatedAt;
        }
    }
}
