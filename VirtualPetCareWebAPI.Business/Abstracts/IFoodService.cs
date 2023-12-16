using VirtualPetCareWebAPI.Core.Utilities.Results.Abstracts;
using VirtualPetCareWebAPI.Entity.Concretes.Requests;
using VirtualPetCareWebAPI.Entity.Concretes.Responses;

namespace VirtualPetCareWebAPI.Business.Abstracts
{
    public interface IFoodService
    {
        IResult Add(AddFoodRequest addFoodRequest);
        IResult Update(UpdateFoodRequest updateFoodRequest);
        IResult Delete(int foodId);
        IDataResult<List<GetFoodResponse>> GetAll();
        IDataResult<GetFoodResponse> GetFoodById(int foodId);
    }
}
