namespace ProductionApp.Repository.Seeds;

public class StockSeed : IEntityTypeConfiguration<Stock>
{
    public void Configure(EntityTypeBuilder<Stock> builder)
    {
        builder.HasData(new Stock[]
        {
            new()
            {
                Id= 1,
                Code="152.11.001",
                Name="Samsung Galaxy Z Fold3",
                Description="Samsung Galaxy Z Fold3, Samsung Galaxy Z Fold3, Samsung Galaxy Z Fold3",
                CreatedDate= DateTime.Now,
                Price=10707,
                VAT=18,
                GroupId=1
            },
            new()
            {
                Id= 2,
                Code="152.11.002",
                Name="Samsung Galaxy Z Flip3",
                Description="Samsung Galaxy Z Flip3, Samsung Galaxy Z Flip3, Samsung Galaxy Z Flip3",
                CreatedDate= DateTime.Now,
                Price=10340,
                VAT=18,
                GroupId=1
            },
            new()
            {
                Id= 3,
                Code="152.11.003",
                Name="Samsung Galaxy S20 FE (SM-G780G)",
                Description="Samsung Galaxy S20 FE (SM-G780G), Samsung Galaxy S20 FE (SM-G780G), Samsung Galaxy S20 FE (SM-G780G)",
                CreatedDate= DateTime.Now,
                Price=8068,
                VAT=18,
                GroupId=1
            },
            new()
            {
                Id= 4,
                Code="152.21.001",
                Name="Apple iPhone 11 64 CB Siyah",
                Description="Apple iPhone 11 64 CB Siyah, Apple iPhone 11 64 CB Siyah, Apple iPhone 11 64 CB Siyah",
                CreatedDate= DateTime.Now,
                Price=10787,
                VAT=18,
                GroupId=1
            },
            new()
            {
                Id= 5,
                Code="152.21.002",
                Name="Apple iPhone 12 64 CB Siyah",
                Description="Apple iPhone 12 64 CB Siyah, Apple iPhone 12 64 CB Siyah, Apple iPhone 12 64 CB Siyah",
                CreatedDate= DateTime.Now,
                Price=10787,
                VAT=18,
                GroupId=1
            }
        });
    }
}
