using Microsoft.AspNetCore.Mvc;
using Server.Dtos;
using Server.Services;

namespace Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodoController: ControllerBase
    {
        ITodoService _service;

        public TodoController(ITodoService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<ActionResult> PostTodo([FromBody]DtoTodoWrite dto)
        {
            return Ok(_service.Add(dto));
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            return Ok(_service.GetAll());
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteTodo()
        {
            return Ok();
        }
    }
}
