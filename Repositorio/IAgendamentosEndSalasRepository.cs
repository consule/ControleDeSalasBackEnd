using ControleDeSalasBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeSalasBackEnd.Repositorio
{
    public interface IAgendamentosEndSalasRepository
    {
        List<AgendamentosEndSalas> GetAll();
    }
}
