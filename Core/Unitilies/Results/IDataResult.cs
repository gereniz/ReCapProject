using System;
namespace Core.Unitilies.Results
{
    public interface IDataResult<T> : IResult
    {
        T Data { get; }
    }
}
