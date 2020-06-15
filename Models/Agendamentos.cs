using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeSalasBackEnd.Models
{
    // Mapeamento da tabela Agendamentos do banco de dados ControleDeSalas
    public class Agendamentos
    {
        public int Id { get; set; }
        public int IdSala { get; set; }
        public string Titulo { get; set; }
        public DateTime DataHoraInicial { get; set; }
        public DateTime DataHoraFinal { get; set; }

    }
}
