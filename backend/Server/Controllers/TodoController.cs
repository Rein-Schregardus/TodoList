using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers
{
    public class TodoController: ControllerBase
    {
        public async Task<ActionResult> PostTodo()
        {
            return Ok();
        }

        public async Task<ActionResult> GetAll()
        {
            return Ok();
        }

        public async Task<ActionResult> DeleteTodo()
        {
            return Ok();
        }
    }
}
