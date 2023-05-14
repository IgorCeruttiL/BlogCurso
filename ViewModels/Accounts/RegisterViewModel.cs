using System.ComponentModel.DataAnnotations;

namespace Blog.ViewModels.Accounts;

public class RegisterViewModel
{
    [Required(ErrorMessage = "O nome é obrigatório")]
    [StringLength(70), MinLength(3, ErrorMessage = "O nome deve ser entre 3 e 70 caracteres")]
    public string Name { get; set; }
    [Required(ErrorMessage = "O Email é obrigatório")]
    [EmailAddress(ErrorMessage = "O Email é inválido")]
    public string Email { get; set; }
    
}