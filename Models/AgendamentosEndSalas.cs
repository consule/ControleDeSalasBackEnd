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
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }    
        public string NomeSala { get; set; }
        public int CapacidadeSala { get; set; }
    }
}
