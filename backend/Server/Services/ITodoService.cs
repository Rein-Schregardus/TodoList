using Server.Dtos;
using Server.Models;

namespace Server.Services
{
    public interface ITodoService
    {
        public DtoTodoRead Add(DtoTodoWrite todo);
        public DtoTodoRead[] GetAll();

    }
}
