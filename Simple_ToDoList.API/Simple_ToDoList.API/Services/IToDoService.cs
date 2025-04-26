namespace Simple_ToDoList.API.Services
{
    public interface IToDoService
    {
        public IEnumerable<ToDo> GetAllToDos();
        public void AddToDo(ToDo toDo);
    }

}
