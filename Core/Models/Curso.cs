using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Curso
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CargaHoraria { get; set; }
        public string Professor { get; set; }
        public string Trilha { get; set; }

    }
}
