namespace book_app.Models
{
    public interface IDatabaseSettings
    {
        string ConnectionStrings { get; set; }
        string DatabaseName { get; set; }
        string BooksCollectionName { get; set; }
        string LogsCollectionName { get; set; }
    }
}
