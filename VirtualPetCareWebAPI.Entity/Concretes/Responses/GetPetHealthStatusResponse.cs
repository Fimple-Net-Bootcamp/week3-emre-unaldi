
namespace VirtualPetCareWebAPI.Entity.Concretes.Responses
{
    public class GetPetHealthStatusResponse
    {
        public int Id { get; set; }
        public bool VaccinationStatus { get; set; }
        public string VetVisits { get; set; }
        public string DiseasesAllergies { get; set; }
    }
}
