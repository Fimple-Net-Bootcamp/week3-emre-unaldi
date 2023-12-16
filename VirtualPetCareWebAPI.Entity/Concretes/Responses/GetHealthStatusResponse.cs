
namespace VirtualPetCareWebAPI.Entity.Concretes.Responses
{
    public class GetHealthStatusResponse
    {
        public int Id { get; set; }
        public bool VaccinationStatus { get; set; }
        public string VetVisits { get; set; }
        public string DiseasesAllergies { get; set; }
        public virtual GetHealthStatusPetResponse Pet { get; set; }
    }
}
