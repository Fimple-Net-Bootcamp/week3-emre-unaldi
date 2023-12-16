using VirtualPetCareWebAPI.Core.Utilities.Results.Abstracts;
using VirtualPetCareWebAPI.Entity.Concretes.Requests;
using VirtualPetCareWebAPI.Entity.Concretes.Responses;

namespace VirtualPetCareWebAPI.Business.Abstracts
{
    public interface IActivityService
    {
        IResult Add(AddActivityRequest addActivityRequest);
        IResult Update(UpdateActivityRequest updateActivityRequest);
        IResult Delete(int activityId);
        IDataResult<List<GetActivityResponse>> GetAll();
        IDataResult<GetActivityResponse> GetActivityById(int activityId);
    }
}
