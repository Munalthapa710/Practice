using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bulkyweb.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Category Name is required.")]
        [MaxLength(30, ErrorMessage = "Category Name cannot exceed 30 characters.")]
        public string Name { get; set; } = string.Empty;

        [DisplayName("Display Order")]
        [Required(ErrorMessage = "Display Order is required.")]
        [MaxLength(3, ErrorMessage = "Display Order cannot exceed 3 characters.")]
        public string DisplayOrder { get; set; } = string.Empty;
    }
}