using System.Collections.Generic;

namespace SistemaGestaoDeBovinos.Models
{
    public class Lote
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public long? PastoAtualId { get; set; }
        public Pasto PastoAtual { get; set; }
        public ICollection<Animal> Animais { get; set; }
    }
}
