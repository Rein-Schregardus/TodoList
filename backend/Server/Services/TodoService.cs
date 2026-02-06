using Server.Dtos;
using Server.Models;

namespace Server.Services
{
    public class TodoService: ITodoService
    {
        private AppDbContext _db;
        public TodoService(AppDbContext db) { _db = db; }

        public DtoTodoRead Add(DtoTodoWrite witeDto)
        {
            Todo todo = MapToTodo(witeDto);

            _db.Todos.Add(todo);
            _db.SaveChanges();

            return MapToReadDto(todo);
        }

        public DtoTodoRead[] GetAll()
        {
            DtoTodoRead[] todos = 
                _db.Todos.AsEnumerable()
                .Select(t => MapToReadDto(t))
                .ToArray();
            return todos;
        }


        private DtoTodoRead MapToReadDto(Todo todo)
        {
            return new DtoTodoRead() 
            {
                Id = todo.Id,
                Title = todo.Title,
                Description = todo.Description,
            };
        }

        private Todo MapToTodo(DtoTodoWrite dto)
        {
            return new Todo() { Title = dto.Title, Description = dto.Description };
        }
    }
}
