using System;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MvcMovie.Model;

namespace MvcMovie.Infrastructure
{
    public class MovieContext
    {
        private readonly IMongoDatabase _database = null;

        public MovieContext(IOptions<Settings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            if (client != null)
                _database = client.GetDatabase(settings.Value.Database);
        }

        public IMongoCollection<Movie> Movies{
            get{
                return _database.GetCollection<Movie>("Movies");
            }
        }
    }
}
