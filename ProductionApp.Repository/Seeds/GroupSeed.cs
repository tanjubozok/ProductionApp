using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductionApp.Entities.Models;

namespace ProductionApp.Repository.Seeds;

public class GroupSeed : IEntityTypeConfiguration<Group>
{
    public void Configure(EntityTypeBuilder<Group> builder)
    {
        builder.HasData(new Group[]
        {
            new()
            {
                Id = 1,
                Code="01",
                Name="Telefon",
                CreatedDate = DateTime.Now
            },
            new()
            {
                Id = 2,
                Code="02",
                Name="Bilgisayar",
                CreatedDate = DateTime.Now
            },
            new()
            {
                Id = 3,
                Code="03",
                Name="Tablet",
                CreatedDate = DateTime.Now
            },
            new()
            {
                Id = 4,
                Code="04",
                Name="Tv",
                CreatedDate = DateTime.Now
            },
            new()
            {
                Id = 5,
                Code="05",
                Name="Beyaz Eşya",
                CreatedDate = DateTime.Now
            },
            new()
            {
                Id = 6,
                Code="06",
                Name="Oyun Konsolları",
                CreatedDate = DateTime.Now
            },
        });
    }
}
