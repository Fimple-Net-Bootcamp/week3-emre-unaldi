
namespace VirtualPetCareWebAPI.Entity.Concretes.Requests
{
    public class UpdateFoodRequest
    {
        public int Id { get; set; }
        public string FoodName { get; set; }
        public string FoodType { get; set; }
        public string Content { get; set; }
        public int PetId { get; set; }
    }
}
