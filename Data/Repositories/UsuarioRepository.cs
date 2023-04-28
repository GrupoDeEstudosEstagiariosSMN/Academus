namespace data.Repositories
{
    public class UsuarioRepository //: IUsuarioRepository TODO: implementar interface
    {
        private readonly ApplicationDbContext _Dbcontext;

        public UsuarioRepository(ApplicationDbContext dbcontext)
        {
            _Dbcontext = dbcontext;
        }

        public async Task Cadastrar(Usuario usuario)
        {
            await _Dbcontext.Usuarios.AddAsync(usuario);
            await _Dbcontext.SaveChangesAsync();
        }



        
    }
}