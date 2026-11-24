using System.ComponentModel.DataAnnotations.Schema;

namespace Gym.Entities
{
    public class MemberShip :BaseEntity
    {
        public int MemberId { get; set; }

        public Member Member { get; set; }
        
        public int PlanId { get; set; }

        public Plan Plan { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        // coloumn stutus not coloumn in the database 

        [NotMapped]
        public string status => StartDate > DateTime.Now ? "Upcoming"
                               : EndDate > DateTime.Now ? "Active "
                               : "Expierd";


    }
}
