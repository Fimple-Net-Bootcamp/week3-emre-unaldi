using VirtualPetCareWebAPI.Core.Utilities.Results.Abstracts;
using VirtualPetCareWebAPI.Entity.Concretes.Requests;
using VirtualPetCareWebAPI.Entity.Concretes.Responses;

namespace VirtualPetCareWebAPI.Business.Abstracts
{
    public interface IPetService
    {
        IResult Add(AddPetRequest addPetRequest);
        IResult Update(UpdatePetRequest updatePetRequest);
        IResult Delete(int petId);
        IDataResult<List<GetPetResponse>> GetAll();
        IDataResult<GetPetResponse> GetPetById(int petId);
    }
}
