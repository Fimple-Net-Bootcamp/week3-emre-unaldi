using VirtualPetCareWebAPI.DataAccess.Abstracts;
using VirtualPetCareWebAPI.Entity.Concretes.Entities;

namespace VirtualPetCareWebAPI.DataAccess.Concretes.EntityFramework
{
    public class EfHealthStatusDal : EfEntityRepositoryBase<HealthStatus, PetCareDbContext>, IHealthStatusDal
    {

    }
}
