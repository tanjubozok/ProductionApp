using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductionApp.Entities.Models;

namespace ProductionApp.Repository.Configurations;

public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
{
    public void Configure(EntityTypeBuilder<AppUser> builder)
    {
        builder.ToTable("AppUsers");      

        builder.Property(x => x.Name)
            .HasMaxLength(50);

        builder.Property(x => x.Surname)
            .HasMaxLength(50);

        builder.HasOne(x => x.City)
            .WithOne(x => x.AppUser)
            .HasForeignKey<City>(x => x.AppUserId);


        builder.HasOne(x => x.District)
            .WithOne(x => x.AppUser)
            .HasForeignKey<District>(x => x.AppUserId);


        builder.HasOne(x => x.CustomerType)
            .WithOne(x => x.AppUser)
            .HasForeignKey<CustomerType>(x => x.AppUserId);
    }
}
