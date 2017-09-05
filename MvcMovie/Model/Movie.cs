using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace MvcMovie.Model
{
    public class Movie
    {
        //[BsonId]
        //public string Id { get; set; }
        public ObjectId Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int AgeRestriction { get; set; }
        public DateTime CreatedOn { get; set; }

        public Movie()
        {
            
        }
    }
}
