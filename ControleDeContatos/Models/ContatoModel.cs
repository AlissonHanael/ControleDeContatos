using System.ComponentModel.DataAnnotations;

namespace ControleDeContatos.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Preencha o Nome do contato")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Preencha o Email do contato")]
        [EmailAddress(ErrorMessage = "Email não é valido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Preencha o telefone do contato")]
        [Phone(ErrorMessage = "Telefone inválido")]
        public string Telefone { get; set; }
    }
}
