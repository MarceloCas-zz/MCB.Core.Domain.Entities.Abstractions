using MCB.Core.Domain.Entities.Abstractions.ValueObjects;
using MCB.Core.Infra.CrossCutting.DesignPatterns.Validator.Abstractions.Models;

namespace MCB.Core.Domain.Entities.Abstractions
{
    public interface IDomainEntity
    {
        // Properties
        Guid Id { get; }
        Guid TenantId { get; }
        AuditableInfoValueObject AuditableInfo { get; }
        DateTimeOffset RegistryVersion { get; }
        IEnumerable<ValidationMessage> ValidationMessageCollection { get; }
    }
}
