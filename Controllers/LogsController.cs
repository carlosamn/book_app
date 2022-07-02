using book_app.Models;
using book_app.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace book_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogsController : ControllerBase
    {

        private readonly IlogService _logsService;
        public LogsController(IlogService logService)
        {
            this._logsService = logService;
        }
        // GET: api/<LogsController>
        [HttpGet]
        public ActionResult<List<Log>> Get()
        {
            return _logsService.Get();
        }

        // POST api/<LogController>
        [HttpPost]
        public ActionResult<Log> Post([FromBody] Log log)
        {
            _logsService.Create(log);
            return CreatedAtAction(nameof(Get), new { id = log.Id }, log);
        }

    }
}
