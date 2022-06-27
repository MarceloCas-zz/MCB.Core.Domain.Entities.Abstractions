namespace MCB.Core.Domain.Entities.Abstractions.Specifications.Interfaces;

public interface IDomainEntitySpecifications
{
    bool IdShouldRequired(Guid id);
    bool TenantIdShouldRequired(Guid tenantId);

    bool CreatedAtShouldRequired(DateTimeOffset createdAt);
    bool CreatedAtShouldValid(DateTimeOffset createdAt);

    bool CreatedByShouldRequired(string createdBy);
    bool CreatedByShouldValid(string createdBy);

    bool LastUpdatedByShouldRequired(DateTimeOffset? lastUpdatedAt);
    bool LastUpdatedByShouldValid(DateTimeOffset? lastUpdatedAt);

    bool LastUpdatedByShouldRequired(string lastUpdatedBy);
    bool LastUpdatedByShouldValid(string lastUpdatedBy);

    bool LastSourcePlatformShouldRequired(string lastSourcePlatform);
    bool LastSourcePlatformShouldValid(string lastSourcePlatform);

    bool RegistryVersionShouldRequired(DateTimeOffset registryVersion);
    bool RegistryVersionShouldValid(DateTimeOffset registryVersion);
}
