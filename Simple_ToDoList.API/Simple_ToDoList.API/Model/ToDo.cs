using System.ComponentModel.DataAnnotations;

namespace Simple_ToDoList.API.Model
{
    public class ToDo
    {
        public int Id { get; set; }

        [MaxLength(5,ErrorMessage ="لابد ان لا يتعدى طول النص عن 5 حروف")]
        public string Title { get; set; } = null!;

        public bool IsCompleted { get; set; }
    }
}
