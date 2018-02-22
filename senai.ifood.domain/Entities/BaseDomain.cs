using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace senai.ifood.domain.Entities
{
    //CLASSE PAI :: ABSTRACT NÃO PODE INSTANCIAR
    public abstract class BaseDomain
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DataCriacao { get; set; }
    }
}