using ControleDeSalasBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeSalasBackEnd.Repositorio
{
    public interface IAgendamentosRepository
    {
        // Retorna todos os agendamentos existentes
        List<Agendamentos> GetAll();
        void Add(Agendamentos agendamentos);
        List<Agendamentos> GetAgendamentosExistentes(Agendamentos agendamentos);

    }

  
}
