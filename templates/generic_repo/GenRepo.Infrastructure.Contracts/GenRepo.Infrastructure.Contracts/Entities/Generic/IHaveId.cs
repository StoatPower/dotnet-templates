using System;

/// <summary>
/// This concept/implementation is taken directly from Oskar Dudycz and the wonderful 
/// GoldenEye DDD library. 
/// 
/// https://github.com/oskardudycz/GoldenEye
/// https://github.com/oskardudycz/GoldenEye/blob/f0ff704584701968978fda597987475a396edab2/src/Core/Shared.Core/Objects/General/IHaveId.cs
/// </summary>
namespace GenRepo.Infrastructure.Contracts.Entities.Generic
{
    public interface IHaveId
    {
        object Id { get; }
    }

    public interface IHaveId<out T> : IHaveId
    {
        new T Id { get; }
    }

    public interface IHaveGuidId : IHaveId<Guid>
    {

    }

    public interface IHaveStringId : IHaveId<string>
    {

    }

    public interface IHaveIntId : IHaveId<int>
    {

    }
}
