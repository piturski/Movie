using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Services
{
    public class MovieService
    {
        private readonly MvcMovieContext _context;

        public MovieService(MvcMovieContext context)
        {
            _context = context;
        }

        public async Task<Movie> GetByIdAsync(int id)
        {
            return await _context.Movie.SingleOrDefaultAsync(m => m.ID == id);
        }

        public async Task CreateMovieAsync(Movie movie)
        {
            _context.Movie.Add(movie);
            await _context.SaveChangesAsync();
        }

        public async Task EditMovieAsync(Movie movie)
        {
            _context.Update(movie);
            await _context.SaveChangesAsync();
        }
    }
}
