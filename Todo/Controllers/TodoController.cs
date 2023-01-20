using Microsoft.AspNetCore.Mvc;
using Todo.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Todo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly TodoContext _todoContext;
        // GET: api/<TodoController>

        public TodoController(TodoContext todoContext)
        {
            _todoContext = todoContext;
        }
        [HttpGet]
        public IEnumerable<TodoList> Get()
        {
            return _todoContext.TodoLists.ToList();
        }

        // GET api/<TodoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TodoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TodoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TodoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
