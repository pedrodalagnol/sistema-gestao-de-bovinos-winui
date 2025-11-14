namespace SistemaGestaoDeBovinos.Models
{
    public class Estoque
    {
        public long Id { get; set; }
        public string Item { get; set; }
        public double Quantidade { get; set; }
        public string Unidade { get; set; }
    }
}
