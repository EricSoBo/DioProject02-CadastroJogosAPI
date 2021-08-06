using System.ComponentModel.DataAnnotations;

namespace APICatalogoJogos.InputModel
{
    public class JogoInputModel
    {
        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome do jogo deve conter entre 3 e 100 caracteres")]
        public string Nome { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "O nome da produtora deve conter entre 3 e 100 caracteres")]
        public string Produtora { get; set; }
        [Required]
        [Range(1, 1000, ErrorMessage = "O preço deve ser de no mínimo 1 real e no máximo 1000 reais")]
        public double Preco { get; set; }
        [Required]
        [StringLength(300, MinimumLength = 1, ErrorMessage = "A descrição deve ser de no mínimo 1 caracter e no máximo de 300 caracteres")]
        public string Descricao { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "O gênero deve ser de no mínimo 1 caracter e no máximo de 50 caracteres")]
        public string Genero { get; set; }
    }
}
