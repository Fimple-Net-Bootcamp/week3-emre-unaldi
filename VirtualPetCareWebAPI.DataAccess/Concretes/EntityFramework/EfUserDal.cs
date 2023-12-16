using VirtualPetCareWebAPI.DataAccess.Abstracts;
using VirtualPetCareWebAPI.Entity.Concretes.Entities;

namespace VirtualPetCareWebAPI.DataAccess.Concretes.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, PetCareDbContext>, IUserDal
    {

    }
}
