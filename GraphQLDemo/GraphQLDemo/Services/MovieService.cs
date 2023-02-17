﻿using GraphQLDemo.Models;
using GraphQLDemo.Repository;

namespace GraphQLDemo.Services
{
    public class MovieService
    {
        private readonly IDataRepository _dataRepository;

        public MovieService(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }

        [UseFiltering]
        public async Task<IEnumerable<Movie>> GetMovies()
        {
            return await _dataRepository.GetMovies();
        }
    }
}
