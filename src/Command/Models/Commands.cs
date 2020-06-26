using System.ComponentModel.DataAnnotations;

namespace Command.Models
{
    public class Commands
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public string Platform { get; set; }
        
    }
}