namespace MCB.Core.Domain.Entities.Abstractions.Specifications.Interfaces;

public interface IDomainEntitySpecifications
{
    bool IdShouldRequired(Guid id);
    bool TenantIdShouldRequired(Guid tenantId);

    bool CreationInfoShouldRequired(DateTimeOffset createdAt, string createdBy);
    bool CreationInfoShouldValid(DateTimeOffset createdAt, string createdBy);

    bool UpdateInfoShouldRequired(DateTimeOffset lastUpdateDate, string lastUpdatedBy);
    bool UpdateInfoShouldValid(DateTimeOffset createdAt, DateTimeOffset lastUpdatedAt, string lastUpdatedBy);

    bool RegistryVersionShouldRequired(DateTimeOffset registryVersion);
    bool RegistryVersionShouldValid(DateTimeOffset registryVersion);
}
