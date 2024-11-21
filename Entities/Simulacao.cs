using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnergiaRuralApi.Entities
{
    public class Simulacao
    {
        public int SimulacaoId { get; set; }

        [Required]
        public double ConsumoMedio { get; set; }

        [Required]
        public double AreaDisponivel { get; set; }

        [Required]
        public double HorasInsolacao { get; set; }

        [Required]
        public double RetornoFinanceiro { get; set; }

        [Required]
        public int UsuarioId { get; set; }

        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }
    }
}
