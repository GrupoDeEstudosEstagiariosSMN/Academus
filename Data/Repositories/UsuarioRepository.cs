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
            _dbContext.Usuarios.Remove(new Usuario {
                Id = id
            });
            await _dbContext.SaveChangesAsync();
        }

        public async Task EditarAsync (Usuario usuario)
        {
            await _dbContext.UpdateEntryAsync<Usuario>(usuario.Id, new {
                Nome = usuario.Nome,
                Email = usuario.Email
            });
            await _dbContext.SaveChangesAsync();
        }
        public async Task<bool> EmailUnique(string email) => await _dbContext.Usuarios.AnyAsync(x => x.Email == email);
    }
}
