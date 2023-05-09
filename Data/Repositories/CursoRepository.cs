using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public async Task<IEnumerable<Curso>> BuscarCursosAsync()
        {
            return await _dbContext.Cursos.ToListAsync();

        }
        public async Task DeletarAsync(int id)
        {
            var curso = await _dbContext.Cursos.FindAsync(id);
            _dbContext.Cursos.Remove(curso);
            await _dbContext.SaveChangesAsync();

        }
        public async Task EditarAsync(Curso curso)
        {
            //curso = await _dbContext.Cursos.FindAsync(id);
            _dbContext.Cursos.Update(curso);
            await _dbContext.SaveChangesAsync();

        }

    }
}
