using Microsoft.AspNetCore.Mvc;
using Simple_ToDoList.API.Services;

namespace Simple_ToDoList.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDosController : ControllerBase
    {
        private readonly IToDoService<ToDo> _toDoService;

        public ToDosController(IToDoService<ToDo> toDoService)
        {
            _toDoService = toDoService;
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            var todos = _toDoService.GetAllToDos();
            if (todos == null || !todos.Any())
                return NotFound("لا يوجد بيانات لعرضها");

            return Ok(todos);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var task = _toDoService.GetById(id);
            if (task == null)
                return NotFound($"No Invaild Task Id Is {id}");

            return Ok(task);
        }

        [HttpPost]
        public IActionResult AddToDo([FromBody] ToDo model)
        {
            _toDoService.AddToDo(model);
            return Ok(model);
        }

        [HttpPut("{id}")]
        public IActionResult Update([FromBody] ToDo toDo, int id)
        {
            var taskUpdated = _toDoService.Update(toDo, id);
            if (taskUpdated == null)
                return NotFound($"No Task By Id Is {id}");
            return Ok(taskUpdated);
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var taskDeleted = _toDoService.DeleteById(id);
            if (taskDeleted == null)
                return NotFound($"This Task Not Fount By Id Is {id}");
            return Ok(taskDeleted);
        }

    }
}
