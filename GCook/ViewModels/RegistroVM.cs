using System.ComponentModel.DataAnnotations;

namespace GCook.ViewModels
{
    public class RegistroVM
    {
        [Display(Name = "Nome Completo", Prompt = "Informe seu Nome Completo")]
        [Required(ErrorMessage = "Por favor, informe seu Nome")]
        [StringLength(60, ErrorMessage ="O nome deve possuir no maximo 60 caracteres")]
        public string Nome { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Nome Completo", Prompt = "Informe seu Nome Completo")]
        [Required(ErrorMessage = "Por favor, informe seu Nome")]
        public DateTime? DataNascimento { get; set; }

        [Display(Prompt = "Informe seu Email")]
        [Required(ErrorMessage = "Por favor, informe seu Email")]
        [EmailAddress(ErrorMessage = "Por favor, informe um Email Válido")]
        [StringLength(100, ErrorMessage ="O nome deve possuir no maximo 60 caracteres")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Senha de Acesso", Prompt = "Informe uma Senha para Acesso")]
        [Required(ErrorMessage = "Por favor, informe sua Senha de Acesso")]
        [StringLength(20, MinimumLength = 6, ErrorMessage ="A senha deve possuir no mínimo 6 e no máximo 20 caracteres")]
        public string ConfirmacaoSenha { get; set; }

        public IFormFile Foto { get; set; }

        public bool Termos { get; set; } = false;
        
        public bool Enviado { get; set; } = false;
    }
}