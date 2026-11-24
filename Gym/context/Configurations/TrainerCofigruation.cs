using Gym.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gym.context.Configurations
{
    public class TrainerCofigruation : GymUserConfiguration<Trainer>, IEntityTypeConfiguration<Trainer>
    {
        public new void Configure(EntityTypeBuilder<Trainer> builder)
        {
            builder.Property(x => x.CreatedAt)
               .HasColumnName("HireDate")
               .HasDefaultValueSql("GETDATE()");

            base.Configure(builder);
        }
    }
}
