using ControleDeSalasBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeSalasBackEnd.Repositorio
{
    public class SalaRepositorio : ISalasRepositorio
    {
        private readonly SalasDBContext _contexto;
        public SalaRepositorio(SalasDBContext ctx)
        {
            _contexto = ctx;
        }
        public IEnumerable<Salas> GetAll()
        {
            return _contexto.Salas.ToList();
        }
    }
}
