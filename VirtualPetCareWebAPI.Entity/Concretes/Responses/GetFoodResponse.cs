
namespace VirtualPetCareWebAPI.Entity.Concretes.Responses
{
    public class GetFoodResponse
    {
        public int Id { get; set; }
        public string FoodName { get; set; }
        public string FoodType { get; set; }
        public string Content { get; set; }
        public virtual GetFoodPetResponse Pet { get; set; }
    }
}
