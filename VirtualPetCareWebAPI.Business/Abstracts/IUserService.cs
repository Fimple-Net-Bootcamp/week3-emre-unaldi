using VirtualPetCareWebAPI.Core.Utilities.Results.Abstracts;
using VirtualPetCareWebAPI.Entity.Concretes.Requests;
using VirtualPetCareWebAPI.Entity.Concretes.Responses;

namespace VirtualPetCareWebAPI.Business.Abstracts
{
    public interface IUserService
    {
        IResult Add(AddUserRequest addUserRequest);
        IResult Update(UpdateUserRequest updateUserRequest);
        IResult Delete(int userId);
        IDataResult<List<GetUserResponse>> GetAll();
        IDataResult<GetUserResponse> GetUserById(int userId);
    }
}
