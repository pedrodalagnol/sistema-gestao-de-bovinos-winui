using System;

namespace SistemaGestaoDeBovinos.Models
{
    public class EventoAnimal
    {
        public long Id { get; set; }
        public long AnimalId { get; set; }
        public Animal Animal { get; set; }
        public TipoEvento TipoEvento { get; set; }
        public DateTime DataEvento { get; set; }
        public double? Valor { get; set; }
        public string Observacoes { get; set; }
    }
}
