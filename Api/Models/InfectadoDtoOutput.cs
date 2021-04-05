using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
{
    public class InfectadoDtoOutput
    {
        public IEnumerable<InfectadoDto> Infectados { get; set; }

        public InfectadoDtoOutput(IEnumerable<InfectadoDto> infectados)
        {
            Infectados = infectados;
        }
    }
}
