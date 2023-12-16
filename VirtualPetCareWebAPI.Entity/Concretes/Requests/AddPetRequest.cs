
namespace VirtualPetCareWebAPI.Entity.Concretes.Requests
{
    public class AddPetRequest
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Color { get; set; }
        public int UserId { get; set; }
        public int HealthStatusId { get; set; }
    }
}
