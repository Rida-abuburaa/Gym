namespace Gym.Entities
{
    public class Member: GymUser
    {
        public string? Photo { get; set; }

        public ICollection<MemberShip> Membershipssubscribtion { get; set; } = default!;

    }
}
