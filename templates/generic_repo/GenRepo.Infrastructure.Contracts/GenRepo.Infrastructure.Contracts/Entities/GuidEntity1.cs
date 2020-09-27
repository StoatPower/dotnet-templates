using GenRepo.Infrastructure.Contracts.Entities.Generic;
using System;
using System.Diagnostics.CodeAnalysis;

namespace GenRepo.Infrastructure.Contracts.Entities
{
    public class GuidEntity1 : EntityWithGuidIdBase, IEquatable<GuidEntity1>
    {
        public string EntityName { get; set; }

        #region Equality

        public bool Equals([AllowNull] GuidEntity1 other)
        {
            return Id.Equals(other.Id) &&
                   EntityName == other.EntityName;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, EntityName);
        }

        #endregion
    }
 }
