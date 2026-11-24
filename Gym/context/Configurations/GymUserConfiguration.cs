using Gym.Entities;
using Microsoft.EntityFrameworkCore;

namespace Gym.context.Configurations
{
    public class GymUserConfiguration<T> : IEntityTypeConfiguration<T> where T : GymUser
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<T> builder)
        {
            builder.Property(x => x.Name)
                   .HasColumnType("Varchar")
                   .HasMaxLength(50);

            builder.Property(x => x.Phone)
                   .HasColumnType("Varchar")
                   .HasMaxLength(11);

            builder.Property(x=> x.Email)
                   .HasColumnType("Varchar")
                   .HasMaxLength(100);

            builder.ComplexProperty(x => x.Address);
            builder.HasIndex(x => x.Email).IsUnique();
            builder.HasIndex(x => x.Phone).IsUnique();
            builder.ToTable(T =>
            {
                T.HasCheckConstraint("GymUser_EmailCheck", "[Email] LIKE '%@%.com'");
                T.HasCheckConstraint("GymUser_PhoneCheck", "LEN ([Phone])= 11 AND ([Phone] LIKE '010%' or [Phone] LIKE '011%' or [Phone] LIKE '012%' or [Phone] LIKE '015%')");

            });



        }
    }
}
