using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace senai.ifood.domain.Entities
{
    public class UsuarioPermissaoDomain : BaseDomain
    {
        [ForeignKey("UsuarioId")]
        public UsuarioDomain Usuario { get; set; }

        [Required]
        public int UsuarioId { get; set; }
        
        [ForeignKey("PermissaoId")]
        public PermissaoDomain Permissao { get; set; }

        [Required]
        public int PermissaoId { get; set; }


    }
}