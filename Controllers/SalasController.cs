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
    public class SalasController : ControllerBase
    {
        private readonly ISalasRepositorio _salaRepositorio;
        public SalasController(ISalasRepositorio salaRepo)
        {
            _salaRepositorio = salaRepo;
        }

        [HttpGet]
        public IEnumerable<Salas> GetAll()
        {
            return _salaRepositorio.GetAll();
        }
    }
}
