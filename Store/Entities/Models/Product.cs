using System.ComponentModel.DataAnnotations;

namespace Entities.Models;

public class Product
{
    public int ProductId { get; set; }

    [Required(ErrorMessage = "ProdcutName required")]
    public string? ProductName { get; set; }

    [Required(ErrorMessage = "ProdcutName required")]
    public decimal Price { get; set; }
}