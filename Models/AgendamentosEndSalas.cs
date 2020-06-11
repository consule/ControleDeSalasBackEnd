using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeSalasBackEnd.Models
{
    public class AgendamentosEndSalas
    {
        public int IdAgendamento { get; set; }
        public int IdSala { get; set; }
        public string Titulo { get; set; }
        public DateTime DataHoraInicial { get; set; }
        public DateTime DataHoraFinal { get; set; }
        public DateTime DataCriacaoAgendamento { get; set; }
        public string NomeSala { get; set; }
        public int CapacidadeSala { get; set; }
    }
}
