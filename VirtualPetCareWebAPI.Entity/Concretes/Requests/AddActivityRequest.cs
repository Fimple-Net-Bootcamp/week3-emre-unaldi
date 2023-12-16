
namespace VirtualPetCareWebAPI.Entity.Concretes.Requests
{
    public class AddActivityRequest
    {
        public string ActivityType { get; set; }
        public string Notes { get; set; }
        public int PetId { get; set; }
    }
}
