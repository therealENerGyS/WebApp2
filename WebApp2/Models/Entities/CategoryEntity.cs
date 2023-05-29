using System.ComponentModel.DataAnnotations;

namespace WebApp2.Models.Entities;

public class CategoryEntity
{
    [Key]
    public int Id { get; set; }

    public string? Name { get; set; }

    public ICollection<ProductTagEntity> ProductCategories { get; set; } = new HashSet<ProductTagEntity>();
}
