using GenRepo.Infrastructure.Contracts.Entities.Generic;
using System;
using System.Diagnostics.CodeAnalysis;

namespace GenRepo.Infrastructure.Contracts.Entities
{
    public class IntEntity1 : EntityWithIntIdBase, IEquatable<IntEntity1>
    {
        public string EntityName { get; set; }

        #region Equality

        public bool Equals([AllowNull] IntEntity1 other)
        {
            return Id == other.Id &&
                   EntityName == other.EntityName;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, EntityName);
        }

        #endregion
    }
}
