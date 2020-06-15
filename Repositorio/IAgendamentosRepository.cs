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

        // Adiciona um novo agendamento
        void Add(Agendamentos agendamentos);       

        // Verifica se existe um agendamento existente conforme dados informados na requisição de reserva
        List<Agendamentos> GetAgendamentosExistentes(int idSala, DateTime dataHoraInicial, DateTime dataHoraFinal);

    }

  
}
