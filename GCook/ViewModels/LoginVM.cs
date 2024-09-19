using System.ComponentModel.DataAnnotations;

namespace GCook.ViewModels
{
    public class LoginVM
    {
        [Display(Name = "Email ou Nome de Usuário", Prompt = "Informe seu Email ou Nome de Usuário")]
        [Required(ErrorMessage = "Por favor, informe seu email ou nome do usuário")]
        public string Email { get; set; }

        [Display(Name = "Senha de Acesso", Prompt = "**********")]
        [Required(ErrorMessage = "Por favor, informe sua senha")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Display(Name = "Manter conectado")]
        public bool Lembrar { get; set; }

        public string UrlRetorno { get; set; }
    }
}