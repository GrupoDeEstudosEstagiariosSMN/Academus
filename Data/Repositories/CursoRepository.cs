namespace Data.Repositories
{
    public class CursoRepository : ICursoRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public CursoRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Cadastrar(Curso curso)
        {
            await _dbContext.Cursos.AddAsync(curso);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Curso>> BuscarCursosAsync(string nomeCurso)
        {
            // AsQueryable possibilita fazer uma query mais flexivel, é basicamente a concatenação pedaços de uma query maior
            var query = _dbContext.Cursos
                .AsQueryable();

            // Validando se foi enviado nome pra busca
            if (!string.IsNullOrEmpty(nomeCurso))
                // Função EF.Functions.Like é como o LIKE do sql q é melhor para fazer buscas com string 
                query.Where(x => EF.Functions.Like(x.Nome, nomeCurso));

            // ToArrayAsync é mais leve e rapido que o ToListAsync
            return await query
                .ToArrayAsync();
        }

        // public async Task<IEnumerable<Curso>> BuscarCursosAsync(string nomeCurso)
        // {
        //     if (string.IsNullOrEmpty(nomeCurso))
        //         return await _dbContext.Cursos.ToListAsync();
        //     else
        //         return await _dbContext.Cursos.Where(x => x.Nome.ToLower() == nomeCurso.ToLower()).ToListAsync();
        // }

        public async Task DeletarAsync(int id)
        {
            var curso = await _dbContext.Cursos.FindAsync(id);
            _dbContext.Cursos.Remove(curso);
            await _dbContext.SaveChangesAsync();
        }

        public async Task EditarAsync(Curso curso)
        {
            _dbContext.Cursos.Update(curso);
            await _dbContext.SaveChangesAsync();
        }
    }
}
