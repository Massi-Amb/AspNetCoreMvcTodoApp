using AspNetCoreMvcTodoApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AspNetCoreMvcTodoApp.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
    }

}
// @todo.Description
//@using(Html.BeginForm("Delete", "Todo", new { id = todo.Id }, FormMethod.Post))
//{
//    < input type = "submit" value = "Delete" class= "btn btn-danger" />
//}