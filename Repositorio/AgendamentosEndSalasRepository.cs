using ControleDeSalasBackEnd.Models;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeSalasBackEnd.Repositorio
{
    public class AgendamentosEndSalasRepository : IAgendamentosEndSalasRepository
    {
        private readonly AgendamentosEndSalasDbContext _contexto;

        public AgendamentosEndSalasRepository(AgendamentosEndSalasDbContext _ctx)
        {
            _contexto = _ctx;

        }
        public List<AgendamentosEndSalas> GetAll()
        {
            var query = (from sl in _contexto.Salas 
                         join ag in _contexto.Agendamentos on sl.Id equals ag.IdSala into grouping
                         from ag in grouping.DefaultIfEmpty()
                         select new AgendamentosEndSalas
                         {
                             IdAgendamento = ag.Id,
                             IdSala = ag.IdSala,
                             Titulo = ag.Titulo,
                             DataHoraInicial = ag.DataHoraInicial,
                             DataHoraFinal = ag.DataHoraFinal,
                             DataCriacaoAgendamento = ag.DataCriacao, 
                             NomeSala = sl.Nome, 
                             CapacidadeSala = sl.Capacidade
                         }).ToList();   
            return query;
        }
    }
}
