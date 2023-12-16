
namespace VirtualPetCareWebAPI.Entity.Concretes.Requests
{
    public class UpdateActivityRequest
    {
        public int Id { get; set; }
        public string ActivityType { get; set; }
        public string Notes { get; set; }
        public int PetId { get; set; }
    }
}
