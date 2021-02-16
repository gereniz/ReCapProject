using System;
namespace Core.Unitilies.Results
{
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
