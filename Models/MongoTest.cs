using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace UniEat.Models
{
    public class MongoTest
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; } = String.Empty;

        [BsonElement("Name")]
        public string Name { get; set; }

    }
}
