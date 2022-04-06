using MCB.Core.Domain.Entities.Abstractions.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;

namespace MCB.Core.Domain.Entities.Abstractions.Tests.ValueObjectsTests
{
    public class AuditableInfoValueObjectTest
    {
        [Fact]
        public void AuditableInfoValueObject_Must_Be_Created_With_CreationInfo()
        {
            // Arrange
            var createdBy = "marcelo.castelo@outlook.com";
            var createdAt = DateTimeOffset.UtcNow;
            var sourcePlatform = "AppDemo";

            // Act
            var auditableInfoValueObject = new AuditableInfoValueObject(
                createdBy,
                createdAt,
                updatedBy: null,
                updatedAt: null,
                sourcePlatform
            );

            // Assert
            auditableInfoValueObject.CreatedBy.Should().Be(createdBy);
            auditableInfoValueObject.CreatedAt.Should().Be(createdAt);
            auditableInfoValueObject.UpdatedBy.Should().BeNull();
            auditableInfoValueObject.UpdatedAt.Should().BeNull();
            auditableInfoValueObject.SourcePlatform.Should().Be(sourcePlatform);
        }

        [Fact]
        public void AuditableInfoValueObject_Must_Be_Created_With_UpdateInfo()
        {
            // Arrange
            var createdBy = "marcelo.castelo@outlook.com";
            var createdAt = DateTimeOffset.UtcNow.AddDays(-1);
            var updatedBy = "marcelo.castelo@github.com";
            var updatedAt = DateTimeOffset.UtcNow;
            var sourcePlatform = "AppDemo";

            // Act
            var auditableInfoValueObject = new AuditableInfoValueObject(
                createdBy,
                createdAt,
                updatedBy,
                updatedAt,
                sourcePlatform
            );

            // Assert
            auditableInfoValueObject.CreatedBy.Should().Be(createdBy);
            auditableInfoValueObject.CreatedAt.Should().Be(createdAt);
            auditableInfoValueObject.UpdatedBy.Should().Be(updatedBy);
            auditableInfoValueObject.UpdatedAt.Should().Be(updatedAt);
            auditableInfoValueObject.SourcePlatform.Should().Be(sourcePlatform);
        }
    }
}
