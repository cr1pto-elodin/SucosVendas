namespace SucosVendas
{
    public class Usuarios
    {
        public Int64 ID { get; set; }
        public string? Nome { get; set; }
        public string? CPF { get; set; }
        public DateTime? DataNascimento { get; set; }
        public Funcao Funcao { get; set; }
    }
}
