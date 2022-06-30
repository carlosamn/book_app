using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace book_app.Models
{
    public class Book
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;

        [BsonElement("title")]
        public string Title { get; set; } = string.Empty;

        [BsonElement("description")]
        public string Description { get; set; } = string.Empty;

        [BsonElement("publish_date")]
        public DateTime PublishDate { get; set; }

        [BsonElement("updated_at")]
        public DateTime updatedAt { get; set; }

        [BsonElement("authors")]
        public string[] Authors { get; set; } = new string[0];

        [BsonElement("change_details")]
        public string changeDetails { get; set; } = String.Empty;
    }
}
