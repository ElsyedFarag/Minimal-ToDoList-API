using Microsoft.AspNetCore.Mvc;
using Simple_ToDoList.API.Services;
using System.Xml.Linq;

namespace Simple_ToDoList.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDosController : ControllerBase
    {
        private readonly IToDoService _toDoService;

        public ToDosController(IToDoService toDoService)
        {
            _toDoService = toDoService;
        }


        [HttpGet]
        [Route("GetToDos")]
        public IActionResult Get()
        {
            var todos = _toDoService.GetAllToDos();
            if (todos == null || !todos.Any())
                return NotFound("لا يوجد بيانات لعرضها");

            return Ok(todos);
        }

        [HttpPost]
        [Route("AddToDo")]
        public IActionResult AddToDo([FromBody] ToDo model)
        {
            _toDoService.AddToDo(model);
            return Ok(model);
        }

    }
}
