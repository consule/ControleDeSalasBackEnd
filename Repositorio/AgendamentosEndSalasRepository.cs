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
        // Metodo que retorna os agendamentos e salas disponíveis utilizando RIGHT JOIN
        public List<AgendamentosEndSalas> GetAll()
        {
            var query = (from sl in _contexto.Salas 
                         join ag in _contexto.Agendamentos on sl.Id equals ag.IdSala into grouping
                         from ag in grouping.DefaultIfEmpty()
                         select new AgendamentosEndSalas
                         {
                             IdSala = ag.IdSala,
                             Titulo = ag.Titulo,
                             DataInicial = ag.DataHoraInicial,
                             DataFinal = ag.DataHoraFinal,                  
                             NomeSala = sl.Nome, 
                             CapacidadeSala = sl.Capacidade
                         }).ToList();   
            return query;
        }
    }
}
