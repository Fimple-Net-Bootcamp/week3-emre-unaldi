using System.ComponentModel.DataAnnotations.Schema;
using VirtualPetCareWebAPI.Entity.Abstracts;

namespace VirtualPetCareWebAPI.Entity.Concretes.Entities
{
    public class Activity : IEntity
    {
        public int Id { get; set; }
        public string ActivityType { get; set; }
        public string Notes { get; set; }

        // Activity - Pet (One To Many)
        public int PetId { get; set; }
        [ForeignKey("PetId")]
        public virtual Pet Pet { get; set; }
    }
}
