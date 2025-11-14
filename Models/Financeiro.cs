using System;

namespace SistemaGestaoDeBovinos.Models
{
    public class Financeiro
    {
        public long Id { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public DateTime Data { get; set; }
        public string Tipo { get; set; } // "Entrada" ou "Saída"
    }
}
