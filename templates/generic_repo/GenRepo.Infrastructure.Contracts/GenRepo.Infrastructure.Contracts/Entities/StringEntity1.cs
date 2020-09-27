using GenRepo.Infrastructure.Contracts.Entities.Generic;
using System;
using System.Diagnostics.CodeAnalysis;

namespace GenRepo.Infrastructure.Contracts.Entities
{
    public class StringEntity1 : EntityWithStringIdBase, IEquatable<StringEntity1>
    {
        public string EntityName { get; set; }

        #region Equality

        public bool Equals([AllowNull] StringEntity1 other)
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
