using System.ComponentModel.DataAnnotations.Schema;
using VirtualPetCareWebAPI.Entity.Abstracts;

namespace VirtualPetCareWebAPI.Entity.Concretes.Entities
{
    public class Food : IEntity
    {
        public int Id { get; set; }
        public string FoodName { get; set; }
        public string FoodType { get; set; }
        public string Content { get; set; }

        // Food - Pet (One To Many)
        public int PetId { get; set; }
        [ForeignKey("PetId")]
        public virtual Pet Pet { get; set; }
    }
}
