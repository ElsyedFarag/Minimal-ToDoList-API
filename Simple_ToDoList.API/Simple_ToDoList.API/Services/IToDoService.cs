namespace Simple_ToDoList.API.Services
{
    public interface IToDoService<T> where T : class
    {

        public IEnumerable<T> GetAllToDos();
        public T GetById(int id);
        public void AddToDo(T toDo);
        public T Update(T toDo, int id);
        public T DeleteById(int id);
    }

}
