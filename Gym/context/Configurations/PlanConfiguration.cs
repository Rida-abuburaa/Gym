using Gym.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gym.context.Configurations
{
    public class PlanConfiguration : IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.Property(x => x.CreatedAt)
                  .HasDefaultValueSql("GETDATE()");

            builder.ToTable(T =>
            {
                T.HasCheckConstraint("PlanDurtionCkeck", "DurationDays Between 1 and 365");
                
            });
        }
    }
}
