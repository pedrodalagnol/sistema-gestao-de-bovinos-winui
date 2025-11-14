using System;
using System.Collections.Generic;

namespace SistemaGestaoDeBovinos.Models
{
    public class Animal
    {
        public long Id { get; set; }
        public string Identificador { get; set; }
        public string Sexo { get; set; }
        public string Raca { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Status { get; set; }
        public double Gmd { get; set; }
        public long? LoteId { get; set; }
        public Lote Lote { get; set; }
        public List<EventoAnimal> Historico { get; set; }
    }
}
