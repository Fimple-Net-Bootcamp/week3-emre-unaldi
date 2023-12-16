
namespace VirtualPetCareWebAPI.Entity.Concretes.Requests
{
    public class AddHealthStatusRequest
    {
        public bool VaccinationStatus { get; set; }
        public string VetVisits { get; set; }
        public string DiseasesAllergies { get; set; }
        public int PetId { get; set; }
    }
}
