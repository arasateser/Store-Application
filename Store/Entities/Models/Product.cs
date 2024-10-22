using System.ComponentModel.DataAnnotations;

namespace Entities.Models;

public class Product
{
    public int ProductId { get; set; }

    [Required(ErrorMessage = "ProductName required")]
    public string? ProductName { get; set; }

    [Required(ErrorMessage = "Price required")]
    public decimal Price { get; set; }
}