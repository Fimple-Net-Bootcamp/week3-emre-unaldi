using VirtualPetCareWebAPI.Core.Utilities.Results.Abstracts;
using VirtualPetCareWebAPI.Entity.Concretes.Requests;
using VirtualPetCareWebAPI.Entity.Concretes.Responses;

namespace VirtualPetCareWebAPI.Business.Abstracts
{
    public interface IHealthStatusService
    {
        IResult Add(AddHealthStatusRequest addHealthStatusRequest);
        IResult Update(UpdateHealthStatusRequest updateHealthStatusRequest);
        IResult Delete(int healthStatusId);
        IDataResult<List<GetHealthStatusResponse>> GetAll();
        IDataResult<GetHealthStatusResponse> GetHealthStatusById(int healthStatusId);
    }
}
