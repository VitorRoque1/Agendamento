using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agendamento.Clinica
{
    internal class Consulta
    {
        public string Nome { get; }
        public Consulta(string nome)
        {
            Nome = nome;
        }
    }
}
