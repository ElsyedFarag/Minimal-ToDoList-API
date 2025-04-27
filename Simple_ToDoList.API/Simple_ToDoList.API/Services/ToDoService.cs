
namespace Simple_ToDoList.API.Services
{
    public class ToDoService : IToDoService<ToDo>
    {
        private List<ToDo> _tasks;

        public ToDoService()
        {
            _tasks = new List<ToDo>()
            {
                  new ToDo { Id = 1, Title = "Task 1", IsCompleted = false },
                  new ToDo { Id = 2, Title = "Task 2", IsCompleted = true },
                  new ToDo { Id = 3, Title = "Task 3", IsCompleted = false },
                  new ToDo { Id = 4, Title = "Task 4", IsCompleted = true },
                  new ToDo { Id = 5, Title = "Task 5", IsCompleted = false },
                  new ToDo { Id = 6, Title = "Task 6", IsCompleted = true },
                  new ToDo { Id = 7, Title = "Task 7", IsCompleted = false },
                  new ToDo { Id = 8, Title = "Task 8", IsCompleted = true },
                  new ToDo { Id = 9, Title = "Task 9", IsCompleted = false },
                  new ToDo { Id = 10, Title = "Task 10", IsCompleted = true },
                  new ToDo { Id = 11, Title = "Task 11", IsCompleted = false },
                  new ToDo { Id = 12, Title = "Task 12", IsCompleted = true },
                  new ToDo { Id = 13, Title = "Task 13", IsCompleted = false },
                  new ToDo { Id = 14, Title = "Task 14", IsCompleted = true },
                  new ToDo { Id = 15, Title = "Task 15", IsCompleted = false },
                  new ToDo { Id = 16, Title = "Task 16", IsCompleted = true },
                  new ToDo { Id = 17, Title = "Task 17", IsCompleted = false },
                  new ToDo { Id = 18, Title = "Task 18", IsCompleted = true },
                  new ToDo { Id = 19, Title = "Task 19", IsCompleted = false },
                  new ToDo { Id = 20, Title = "Task 20", IsCompleted = true }
            };
        }

        public void AddToDo(ToDo toDo)
        {
            _tasks.Add(toDo);
        }

        public ToDo DeleteById(int id)
        {
            var task = _tasks.Find(x => x.Id == id);
            if (task != null)
                _tasks.Remove(task!);

            return task!;
        }

        public IEnumerable<ToDo> GetAllToDos()
        {
            return _tasks;
        }

        public ToDo GetById(int id)
        {
            var task = _tasks.Find(x => x.Id == id);

            return task!;
        }

        public ToDo Update(ToDo toDo, int id)
        {
            var task = _tasks.Find(x => x.Id == id);

            if (task != null)
            {
                task.Title = toDo.Title;
                task.IsCompleted = toDo.IsCompleted;
            }
            return task!;
        }
    }
}
