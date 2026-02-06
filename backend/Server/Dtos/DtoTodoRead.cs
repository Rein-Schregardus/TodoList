using System.ComponentModel.DataAnnotations;

namespace Server.Dtos
{
    public class DtoTodoRead
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public string Description { get; set; }
    }
}
