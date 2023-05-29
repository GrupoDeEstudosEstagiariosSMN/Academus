namespace Data
{
    public class ApplicationDbContext : BaseDbContext
    {
        public ApplicationDbContext(AppSettings appSettings) : base(appSettings, "Application") { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<CategoriaCurso> CategoriaCursos { get; set; }
        public DbSet<CursoInstrutor> CursoInstrutores { get; set; }
        public DbSet<Instrutor> Instrutores { get; set; }
        public DbSet<Trilha> Trilhas { get; set; }
        public DbSet<TrilhaCurso> TrilhaCursos { get; set; }
    }
}
