namespace Data.Configurations.Application
{
    public class TrilhaConfiguration : IEntityTypeConfiguration<Trilha>
    {
        public void Configure(EntityTypeBuilder<Trilha> builder)
        {
            builder.ToTable("trilha", "dbo");

            builder.HasKey(x => x.Id).HasName("pk_trilha");

            builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("id");
            builder.Property(x => x.Nome).HasColumnName("nome");
            builder.Property(x => x.Descricao).HasColumnName("descricao");

        }
    }
}