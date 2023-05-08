using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Turma
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int QuantidadeAlunos { get; set; }
        public string Sala { get; set; }
        public string Turno { get; set; }
    }
}