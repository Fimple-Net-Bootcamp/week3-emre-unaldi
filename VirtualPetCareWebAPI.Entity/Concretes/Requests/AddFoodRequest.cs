
namespace VirtualPetCareWebAPI.Entity.Concretes.Requests
{
    public class AddFoodRequest
    {
        public string FoodName { get; set; }
        public string FoodType { get; set; }
        public string Content { get; set; }
        public int PetId { get; set; }
    }
}
