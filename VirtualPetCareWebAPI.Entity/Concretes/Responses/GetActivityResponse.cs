
namespace VirtualPetCareWebAPI.Entity.Concretes.Responses
{
    public class GetActivityResponse
    {
        public int Id { get; set; }
        public string ActivityType { get; set; }
        public string Notes { get; set; }
        public virtual GetActivityPetResponse Pet { get; set; }
    }
}
