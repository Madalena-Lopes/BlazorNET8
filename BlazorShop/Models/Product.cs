using System.ComponentModel.DataAnnotations;

namespace BlazorShop.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Indique o título!")] //isto já gera validações para o EF e para o formulário
        [MinLength(3, ErrorMessage = "A categoria deve ter pelo menos 3 caracteres!")]
        [MaxLength(120, ErrorMessage = "A categoria deve ter no máximo 120 caracteres!")]
        public string Title { get; set; } = string.Empty;
        
        public string? Description { get; set; }

        [Required(ErrorMessage = "Indique o preço do produto!")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;

    }
}
