using System;

/// <summary>
/// This concept/implementation is taken directly, with slight modification, from Oskar Dudycz and the wonderful 
/// GoldenEye DDD library. 
/// 
/// https://github.com/oskardudycz/GoldenEye
/// https://github.com/oskardudycz/GoldenEye/blob/master/src/Core/Shared.Core/Objects/General/ObjectWithIdBase.cs
/// </summary>
namespace GenRepo.Infrastructure.Contracts.Entities.Generic
{
    public abstract class EntityBase : IEntity
    {
    }

    public abstract class EntityWithIdBase : EntityBase, IHaveId
    {
        object IHaveId.Id { get; }
    }

    public abstract class EntityWithIdBase<T> : IHaveId<T>
    {
        public T Id { get; set; }

        object IHaveId.Id
        {
            get { return Id; }
        }
    }

    public abstract class EntityWithGuidIdBase : EntityWithIdBase<Guid>, IHaveGuidId
    {
    }

    public abstract class EntityWithStringIdBase : EntityWithIdBase<string>, IHaveStringId
    {
    }

    public abstract class EntityWithIntIdBase : EntityWithIdBase<int>, IHaveIntId
    {
    }
}
