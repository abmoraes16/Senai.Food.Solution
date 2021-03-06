using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace senai.ifood.domain.Entities
{
    public class ClienteDomain : BaseDomain
    {
        [Required]
        public string Nome { get; set; }
        
        [Required]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }
        
        [Required]
        [StringLength(10)]
        public string Sexo { get; set; }

        [ForeignKey("UsuarioId")]
        public UsuarioDomain Usuario { get; set; }

        public int UsuarioId { get; set; }
    }
}