using System.ComponentModel.DataAnnotations.Schema;
using VirtualPetCareWebAPI.Entity.Abstracts;

namespace VirtualPetCareWebAPI.Entity.Concretes.Entities
{
    public class Pet : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Color { get; set; }


        // Pet - User (Many To One)
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }

        // Pet - Health (One to One)
        public int HealthStatusId { get; set; }
        [ForeignKey("HealthStatusId")]
        public virtual HealthStatus HealthStatus { get; set; }

        // Pet - Activity (One To Many)
        public virtual ICollection<Activity> Activities { get; set; }

        // Pet - Food (One To Many)
        public virtual ICollection<Food> Foods { get; set; }
    }
}