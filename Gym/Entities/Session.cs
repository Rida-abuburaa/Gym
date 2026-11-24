namespace Gym.Entities
{
    public class Session: BaseEntity
    {
        public string Description { get; set; } = default!;

        public string Capacity { get; set; } = default!;

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TrainerId { get; set; }//FK

        public Trainer Trainer { get; set; } = default!;


    }
}
