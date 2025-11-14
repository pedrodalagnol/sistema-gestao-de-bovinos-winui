using System;

namespace SistemaGestaoDeBovinos.Models
{
    public class Pasto
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public double AreaHa { get; set; }
        public PastoStatus Status { get; set; }
        public DateTime DataInicioStatus { get; set; }
        public long? LoteAlocadoId { get; set; }
        public Lote LoteAlocado { get; set; }
    }
}
