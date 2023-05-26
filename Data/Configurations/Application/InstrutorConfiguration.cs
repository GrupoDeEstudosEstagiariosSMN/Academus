namespace Data.Configurations.Application
{
    public class InstrutorConfiguration : IEntityTypeConfiguration<Instrutor>
    {
        public void Configure(EntityTypeBuilder<Instrutor> builder)
        {
            builder.ToTable("instrutor", "dbo");

            builder.HasKey(x => x.Id).HasName("pk_instrutor");

            builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("id");
            builder.Property(x => x.Nome).HasColumnName("nome");
            builder.Property(x => x.Especialidade).HasColumnName("especialidade");
            builder.Property(x => x.Area).HasColumnName("area");

        }
    }
}
