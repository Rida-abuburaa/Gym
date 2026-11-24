using Gym.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gym.context.Configurations
{
    public class MemberShipConfigrution : IEntityTypeConfiguration<MemberShip>
    {
        public void Configure(EntityTypeBuilder<MemberShip> builder)
        {
            builder.HasKey(E => E.Id);
            builder.Property(x => x.CreatedAt)
                  .HasDefaultValueSql("GETDATE()");
        }
    }
}
