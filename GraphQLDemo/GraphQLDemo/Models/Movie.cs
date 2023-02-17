using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace GraphQLDemo.Models
{
    public class Movie
    {
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("id")]
        public string? Id { get; set; }

        [BsonElement("title")]
        public string? Title { get; set; }

        [BsonElement("year")]
        public int Year { get; set; }

        [BsonElement("runtime")]
        public int Runtime { get; set; }

        [BsonElement("genre")]
        public IEnumerable<string> Genre { get; set; } = Enumerable.Empty<string>();

        [BsonElement("cast")]
        public IEnumerable<string> Cast { get; set; } = Enumerable.Empty<string>();

        [BsonElement("__v")]
        public int Version { get; set; }
    }
}
