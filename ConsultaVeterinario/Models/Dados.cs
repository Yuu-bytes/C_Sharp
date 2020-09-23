using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultaVeterinario.Models
{
    public class Dados
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool Admin { get; set; }
        public string Animal { get; set; }
        public DateTime DataHora { get; set; }
        public string Consulta { get; set; }
    }
}
