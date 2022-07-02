using book_app.Models;
using MongoDB.Driver;

namespace book_app.Services
{
    public class LogService: IlogService
    {

        private readonly IMongoCollection<Log> _logs;
        public LogService(Models.IDatabaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _logs = database.GetCollection<Log>(settings.LogsCollectionName);
        }

        public Log Create(Log log)
        {
            log.updatedAt = DateTime.Now;
            _logs.InsertOne(log);
            return log;
        }

        public List<Log> Get()
        {
            return _logs.Find(logs => true).ToList();
        }

       
    }
}
