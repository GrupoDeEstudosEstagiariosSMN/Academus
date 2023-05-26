using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class CursoInstrutor
    {
        public int IdTrilha { get; set; }
        public int IdCurso { get; set; }
        public Trilha Trilha { get; set; }
        public Curso Curso { get; set; }
    }
}