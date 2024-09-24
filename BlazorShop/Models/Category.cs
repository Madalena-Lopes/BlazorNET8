using System.ComponentModel.DataAnnotations;

namespace BlazorShop.Models;

public class Category
{
    [Key]
    public int Id { get; set; }
    
    [Required(ErrorMessage="Indique o título!")] //isto já gera validações para o EF e para o formulário
    [MinLength(3,ErrorMessage = "A categoria deve ter pelo menos 3 caracteres!")]
    [MaxLength(60,ErrorMessage = "A categoria deve ter no máximo 60 caracteres!")]
    public string Title { get; set; } = string.Empty;
}