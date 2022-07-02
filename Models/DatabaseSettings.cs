namespace book_app.Models
{
    public class DatabaseSettings: IDatabaseSettings
    {
        public string ConnectionStrings { get; set; } = String.Empty;
        public string DatabaseName { get; set; } = String.Empty;
        public string BooksCollectionName { get; set; } = String.Empty;
        public string LogsCollectionName { get; set; } = String.Empty;
    }
}
