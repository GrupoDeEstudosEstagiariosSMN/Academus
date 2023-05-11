namespace Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public UsuarioRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CadastrarAsync(Usuario usuario)
        {
            await _dbContext.Usuarios.AddAsync(usuario);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Usuario>> BuscarUsuariosAsync(string nomeUsuario)
        {
            if (string.IsNullOrEmpty(nomeUsuario))
                return await _dbContext.Usuarios.ToListAsync();
            else
                return await _dbContext.Usuarios.Where(x => x.Nome.ToLower() == nomeUsuario.ToLower()).ToListAsync();
        }

        public async Task DeletarAsync(int id)
        {
            _dbContext.Usuarios.Remove(new Usuario
            {
                Id = id
            });
            await _dbContext.SaveChangesAsync();
        }

        public async Task EditarAsync(int id, string nomeUsuario, string emailUsuario)
        {
            await _dbContext.UpdateEntryAsync<Usuario>(id, new
            {
                Nome = nomeUsuario,
                Email = emailUsuario
            });
            await _dbContext.SaveChangesAsync();
        }
    }
}
