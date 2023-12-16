
namespace VirtualPetCareWebAPI.Core.Utilities.Results.Abstracts
{
    public interface IDataResult<out T> : IResult
    {
        T Data { get; }
    }
}
