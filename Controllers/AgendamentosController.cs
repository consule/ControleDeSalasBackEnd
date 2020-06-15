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
    public class AgendamentosController : ControllerBase
    {
        private readonly IAgendamentosRepository _agendamentosRepository;
        public AgendamentosController(IAgendamentosRepository agendamentoRepo)
        {
            _agendamentosRepository = agendamentoRepo;
        }

        [HttpGet]
        public List<Agendamentos> GetAll()
        {
            return _agendamentosRepository.GetAll();
        }

        [HttpPost]
        public IActionResult Create([FromBody] Agendamentos agendamentos)
        {
            if (agendamentos == null)
            {
                return BadRequest();
            }

            _agendamentosRepository.Add(agendamentos);

            return Ok();
        }

        [HttpGet("agendamentosExistentes/{idSala}/{dataHoraInicial}/{dataHoraFinal}")]
        public List<Agendamentos> GetAgendamentoExistente(int idSala, DateTime dataHoraInicial, DateTime dataHoraFinal)
        {
            return _agendamentosRepository.GetAgendamentosExistentes(idSala, dataHoraInicial,  dataHoraFinal);
        }
    }
}
