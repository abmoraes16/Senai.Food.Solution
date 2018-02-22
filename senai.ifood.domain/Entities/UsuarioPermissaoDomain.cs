namespace senai.ifood.domain.Entities
{
    public class UsuarioPermissaoDomain
    {
        public UsuarioDomain Usuario { get; set; }
        public int UsuarioId { get; set; }
        public PermissaoDomain Permissao { get; set; }
        public int PermissaoId { get; set; }


    }
}