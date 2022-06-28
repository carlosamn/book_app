using book_app.Models;

namespace book_app.Services
{
    public interface IBookService
    {

        List<Book> Get();
        Book Get(string id);
        Book Create(Book book);
        void Remove(string id);
        void Update(string id, Book book);

    }
}
