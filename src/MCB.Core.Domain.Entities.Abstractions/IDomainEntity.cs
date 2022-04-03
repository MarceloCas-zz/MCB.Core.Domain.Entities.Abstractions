using MCB.Core.Domain.Entities.Abstractions.ValueObjects;

namespace MCB.Core.Domain.Entities.Abstractions
{
    public interface IDomainEntity
    {
        // Properties
        Guid Id { get; }
        AuditableInfoValueObject AuditableInfo { get; }
        DateTimeOffset RegistryVersion { get; }
    }
}
