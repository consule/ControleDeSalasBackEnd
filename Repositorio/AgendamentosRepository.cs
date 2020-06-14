﻿using ControleDeSalasBackEnd.Models;
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

        public void Add(Agendamentos agendamentos)
        {
            _contexto.Agendamentos.Add(agendamentos);
            _contexto.SaveChanges();
        }

        public List<Agendamentos> GetAll()
        {

            return _contexto.Agendamentos.ToList();
            
        }
    }
}