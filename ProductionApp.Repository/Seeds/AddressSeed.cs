using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductionApp.Entities.Models;

namespace ProductionApp.Repository.Seeds;

public class AddressSeed : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {

    }
}
