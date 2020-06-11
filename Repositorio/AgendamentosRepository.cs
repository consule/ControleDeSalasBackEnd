using ControleDeSalasBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeSalasBackEnd.Repositorio
{
    public class AgendamentosRepository : IAgendamentosRepository
    {
        private readonly AgendamentosDbContext _contexto;

        public AgendamentosRepository(AgendamentosDbContext _ctx)
        {
            _contexto = _ctx;
        }
        public List<Agendamentos> GetAll()
        {
            var query = from ag in Agendamentos join sl in Salas on  ag.IdSala equals sl.id
                        select new { ag, sl }
            return _contexto.Agendamentos.ToList();
            
        }
    }
}
