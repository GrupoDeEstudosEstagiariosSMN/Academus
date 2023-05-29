namespace Data.Configurations.Application
{
    public class PalestraConfiguration : IEntityTypeConfiguration<Palestra>
    {
        public void Configure(EntityTypeBuilder<Palestra> builder)
        {
            builder.ToTable("palestra", "dbo");

            builder.HasKey(x => x.Id).HasName("pk_palestra");
            builder.Property(x => x.IdCategoria).HasColumnName("id_categoria");
            builder.Property(x => x.Nome).HasColumnName("nome");
            builder.Property(x => x.Minutos).HasColumnName("minutos");

            builder.HasOne(x => x.Categoria).WithMany(x => x.Palestras).HasForeignKey(x => x.IdCategoria);
        }
    }
}