
namespace VirtualPetCareWebAPI.Entity.Concretes.Responses
{
    public class GetPetResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Color { get; set; }
        public GetPetUserResponse User { get; set; }   
        public virtual GetPetHealthStatusResponse HealthStatus { get; set; }
        public virtual List<GetPetActivityResponse> Activities { get; set; }
        public virtual List<GetPetFoodResponse> Foods { get; set; }
    }
}
