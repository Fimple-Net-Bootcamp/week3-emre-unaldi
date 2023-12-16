
namespace VirtualPetCareWebAPI.Entity.Concretes.Requests
{
    public class UpdateHealthStatusRequest
    {
        public int Id { get; set; }
        public bool VaccinationStatus { get; set; }
        public string VetVisits { get; set; }
        public string DiseasesAllergies { get; set; }
        public int PetId { get; set; }
    }
}
