using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebInfectado.Models;
using WebInfectado.repositories;

namespace WebInfectado.Services
{
    public class InfectadoService
    {
        private readonly InfectadoRepositorio _context;

        public List<Infectado> ListarTodos()
        {
            var infectadosTask = _context.GetInfectadosAsync();
            List<Infectado> infectadosResult = new List<Infectado>();

            infectadosTask.ContinueWith(task =>
            {
                var infectados = task.Result;
                foreach (var i in infectados)

                    infectadosResult.Add(i);
                Environment.Exit(0);
            },
                TaskContinuationOptions.OnlyOnRanToCompletion
            );

            return infectadosResult;
        }
    }
}
