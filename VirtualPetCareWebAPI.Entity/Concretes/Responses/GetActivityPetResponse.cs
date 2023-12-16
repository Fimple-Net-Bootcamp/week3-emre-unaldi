
namespace VirtualPetCareWebAPI.Entity.Concretes.Responses
{
    public class GetActivityPetResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Color { get; set; }
        public GetPetUserResponse User { get; set; }
    }
}
