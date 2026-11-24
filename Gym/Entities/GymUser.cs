using Gym.Entities.Enum;

namespace Gym.Entities
{
    public class GymUser : BaseEntity
    {
        public string Name { get; set; } = default!;

        public String Email { get; set; } = default!;

        public String Phone { get; set; } = default!;

        public Address Address { get; set; }     

        public DateOnly DateOfBirth { get; set; } 

        public  Gender  Gender { get; set; }  



    }
}
