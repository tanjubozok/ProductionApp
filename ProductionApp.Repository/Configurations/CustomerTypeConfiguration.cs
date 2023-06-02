namespace ProductionApp.Repository.Configurations;

public class CustomerTypeConfiguration : IEntityTypeConfiguration<CustomerType>
{
    public void Configure(EntityTypeBuilder<CustomerType> builder)
    {
        builder.ToTable("CustomerTypes");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .UseIdentityColumn();

        builder.Property(x => x.LongName)
            .IsRequired()
            .HasMaxLength(25);

        builder.Property(x => x.ShortName)
            .IsRequired()
            .HasColumnType("CHAR")
            .HasMaxLength(1);
    }
}
