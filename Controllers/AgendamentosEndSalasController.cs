using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleDeSalasBackEnd.Models;
using ControleDeSalasBackEnd.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ControleDeSalasBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgendamentosEndSalasController : ControllerBase
    {
        private readonly IAgendamentosEndSalasRepository _agendamentoEndSalasRepositorio;
        public AgendamentosEndSalasController(IAgendamentosEndSalasRepository agendasRepo)
        {
            _agendamentoEndSalasRepositorio = agendasRepo;
        }

        [HttpGet]
        public List<AgendamentosEndSalas> GetAll()
        {
            return _agendamentoEndSalasRepositorio.GetAll();
        }
        
    }
}
