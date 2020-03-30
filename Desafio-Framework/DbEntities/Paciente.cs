using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_Framework.DbEntities
{
    public class Paciente
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Pais { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }


    }
}
