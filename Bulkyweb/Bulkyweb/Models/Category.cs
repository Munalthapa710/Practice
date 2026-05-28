using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bulkyweb.Models
{
    public class Category
    {
       
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [MaxLength(3)]
        public string DisplayOrder { get; set; }
    }
}
