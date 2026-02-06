using System.ComponentModel.DataAnnotations;

namespace Server.Models
{
    public class Todo
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public required string Title { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
    }
}
