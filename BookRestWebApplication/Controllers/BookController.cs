// Application URL - https://localhost:7105/api/Book
// Ref URL Code - https://dotnettutorials.net/lesson/microservices-using-asp-net-core/

using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookRestWebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        // GET: api/<BookController>
        [HttpGet]
        public IEnumerable<BookModel> Get()
        {
            BookModel book1 = new BookModel();
            book1.BookId = 1;
            book1.BookName = "Python Programming";
            book1.BookAuthor = "John M Zelle";

            BookModel book2 = new BookModel();
            book2.BookId = 2;
            book2.BookName = "C Sharp in Depth";
            book2.BookAuthor = "Jon Skeet";

            List<BookModel> listofbook = new List<BookModel>
            {
                book1, book2
            };
            return listofbook;
        }

        // GET api/<BookController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BookController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BookController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BookController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
