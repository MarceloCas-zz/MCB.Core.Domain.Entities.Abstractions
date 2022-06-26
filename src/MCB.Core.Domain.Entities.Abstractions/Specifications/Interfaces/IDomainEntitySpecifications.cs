namespace MCB.Core.Domain.Entities.Abstractions.Specifications.Interfaces;

public interface IDomainEntitySpecifications
{
    bool IdShouldRequired(Guid id);
    bool TenantIdShouldRequired(Guid tenantId);

    bool CreationInfoShouldRequired(DateTimeOffset createdAt, string createdBy, string lastSourcePlatform);
    bool CreationInfoShouldValid(DateTimeOffset createdAt, string createdBy, string lastSourcePlatform);

    bool UpdateInfoShouldRequired(DateTimeOffset? lastUpdatedAt, string lastUpdatedBy, string lastSourcePlatform);
    bool UpdateInfoShouldValid(DateTimeOffset createdAt, DateTimeOffset? lastUpdatedAt, string lastUpdatedBy, string lastSourcePlatform);

    bool RegistryVersionShouldRequired(DateTimeOffset registryVersion);
    bool RegistryVersionShouldValid(DateTimeOffset registryVersion);
}
