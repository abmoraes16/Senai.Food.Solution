using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace senai.ifood.domain.Entities
{
    public class RestauranteDomain : BaseDomain
    {
        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        [StringLength(100)]
        public string Responsavel { get; set; }

        [StringLength(50)]
        public string Site { get; set; }

        [Required]
        [StringLength(13)]
        public string Telefone { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [ForeignKey("EspecialidadeId")]
        public EspecialidadeDomain Especialidade { get; set; }
        
        [Required]
        public int EspecialidadeId { get; set; }

        [ForeignKey("UsuarioId")]
        public UsuarioDomain Usuario { get; set; }

        [Required]
        public int UsuarioId { get; set; }

        public ICollection<ProdutoRestauranteDomain> ProdutosRestaurantes { get; set; }
    }
}