using MCB.Core.Infra.CrossCutting.DesignPatterns.Validator.Abstractions;

namespace MCB.Core.Domain.Entities.Abstractions.Validators.Interfaces;

public interface IDomainEntityShouldValidAfterRegisterModificationValidator<TDomainEntity>
    : IValidator<TDomainEntity>
    where TDomainEntity : IDomainEntity
{
}
