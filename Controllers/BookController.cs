using book_app.Models;
using book_app.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace book_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            this._bookService = bookService;
        }

        // GET: api/<BookController>
        [HttpGet]
        public ActionResult<List<Book>> Get()
        {
            return _bookService.Get();
        }

        // GET api/<BookController>/5
        [HttpGet("{id}")]
        public ActionResult<Book> Get(string id)
        {
            var book = _bookService.Get(id);
            if(book == null)
            {
                return NotFound($"Book with id {id} not found");
            }
            return book;
        }

        // POST api/<BookController>
        [HttpPost]
        public ActionResult<Book> Post([FromBody] Book book)
        {
            _bookService.Create(book);
            return CreatedAtAction(nameof(Get), new {id = book.Id}, book);
        }

        // PUT api/<BookController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] Book book)
        {
            var existingBook = _bookService.Get(id);
            if(existingBook == null)
            {
                return NotFound($"Book with id = {id} not found");
            }
            _bookService.Update(id, book);
            return NoContent();
        }

        // DELETE api/<BookController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var book = _bookService.Get(id);
            if (book == null)
            {
                return NotFound($"Book with id {id} not found");
            }
            _bookService.Remove(id);
            return Ok($"Book with id {id} has been deleted");
        }
    }
}
