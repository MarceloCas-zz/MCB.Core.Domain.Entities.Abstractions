namespace MCB.Core.Domain.Entities.Abstractions.ValueObjects
{
    public struct AuditableInfoValueObject
    {
        // Properties
        public string CreatedBy { get; }
        public DateTimeOffset CreatedAt { get; }
        public string? UpdatedBy { get; }
        public DateTimeOffset? UpdatedAt { get; }
        public string SourcePlatform { get; }

        // Constructors
        public AuditableInfoValueObject(
            string createdBy,
            DateTimeOffset createdAt,
            string? updatedBy,
            DateTimeOffset? updatedAt,
            string sourcePlatform
        )
        {
            CreatedBy = createdBy;
            CreatedAt = createdAt;
            UpdatedBy = updatedBy;
            UpdatedAt = updatedAt;
            SourcePlatform = sourcePlatform;
        }
    }
}
