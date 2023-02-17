using GraphQLDemo.Models;
using MongoDB.Driver;

namespace GraphQLDemo.Repository
{
    public class DataRepository : IDataRepository
    {
        private IMongoCollection<Movie> movies;

        public DataRepository()
        {
            var connectionString = Environment.GetEnvironmentVariable("MONGODB_URI");
            var client = new MongoClient(connectionString);
            movies = client.GetDatabase("movies").GetCollection<Movie>("movies");
        }

        public async Task<Movie> CreateMovie(Movie movie)
        {
            await movies.InsertOneAsync(movie);
            return movie;
        }

        public async Task DeleteMovie(string id)
        {
            await movies.DeleteOneAsync(m => m.Id == id);
        }

        public async Task<Movie> GetMovie(string id)
        {
            return await Task.FromResult(new Movie { Id = id });
        }

        public async Task<IEnumerable<Movie>> GetMovies()
        {
            var cursor = await movies.FindAsync(_ => true);
            return await cursor.ToListAsync();
        }

        public async Task<Movie> UpdateMovie(Movie movie)
        {
            var update = Builders<Movie>.Update
                .Set("title", movie.Title)
                .Set("year", movie.Year)
                .Set("runtime", movie.Runtime)
                .Set("genre", movie.Genre)
                .Set("cast", movie.Cast);

            await movies.UpdateOneAsync(m => m.Id == movie.Id, update);
            return movie;
        }
    }
}
