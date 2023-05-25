namespace Data.Configurations.Application
{
    public class Organizador : IEntityTypeConfiguration<Organizador>
    {
        public void Configure(EntityTypeBuilder<Organizador> builder)
        {
            builder.ToTable("organizador", "dbo");
        }
    }
}