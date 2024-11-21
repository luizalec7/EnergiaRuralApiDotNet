using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EnergiaRuralApi.Entities
{
    public class Usuario
    {
        public int UsuarioId { get; set; }

        [Required, MaxLength(255)]
        public string Nome { get; set; }

        [Required, EmailAddress, MaxLength(255)]
        public string Email { get; set; }

        [Required, MaxLength(50)]
        public string Senha { get; set; }

        public ICollection<Simulacao> Simulacoes { get; set; }
    }
}
