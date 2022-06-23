using MCB.Core.Infra.CrossCutting.DesignPatterns.Validator.Abstractions;

namespace MCB.Core.Domain.Entities.Abstractions.Validators.Interfaces;

public interface IDomainEntityShouldValidAfterRegisterNewValidator<TDomainEntity>
    : IValidator<TDomainEntity>
    where TDomainEntity : IDomainEntity
{

}
