using System;

namespace APICatalogoJogos.Entities
{
    public class Jogo
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Produtora { get; set; }
        public double Preco { get; set; }
        public string Descricao { get; set; }
        public string Genero { get; set; }
    }
}
