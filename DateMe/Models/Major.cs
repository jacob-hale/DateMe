using System.ComponentModel.DataAnnotations;

namespace DateMe.Models
{
    public class Major
    {
        [Key]
        [Required]
        public int MajorId { get; set; }
        public string MajorName { get; set; }
    }
}
