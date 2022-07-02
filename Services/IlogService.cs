using book_app.Models;

namespace book_app.Services
{
    public interface IlogService
    {
        List<Log> Get();
        Log Create(Log log);
    }
}
