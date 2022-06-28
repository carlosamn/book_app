using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace book_app.Models
{
    public class Book
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = String.Empty;

        [BsonElement("title")]
        public string Title { get; set; } = String.Empty;

        [BsonElement("description")]
        public string Description { get; set; } = String.Empty;

        [BsonElement("publishDate")]
        public DateTime PublishDate { get; set; }

        [BsonElement("authors")]
        public string Authors { get; set; } = String.Empty;
    }
}
