using System;

namespace ControleDeSalasBackEnd.Models
{
    // Mapeamento da tabela Salas do banco de dados ControleDeSalas
    public class Salas
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Capacidade { get; set; }        
        public DateTime DataCriacao { get; set; }   
    }
}