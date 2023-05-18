using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductionApp.Entities.Models;

namespace ProductionApp.Repository.Seeds;

public class CustomerTypeSeed : IEntityTypeConfiguration<CustomerType>
{
    public void Configure(EntityTypeBuilder<CustomerType> builder)
    {
        builder.HasData(new CustomerType[]
        {
            new()
            {
                Id = 1,
                ShortName = "A",
                LongName = "Alıcı",
            },
            new()
            {
                Id= 2,
                ShortName = "S",
                LongName= "Satıcı",
            }
        });
    }
}
