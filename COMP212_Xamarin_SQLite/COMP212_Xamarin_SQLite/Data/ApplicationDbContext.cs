using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COMP212_Xamarin_SQLite.Droid.Model;
using SQLite;

namespace COMP212_Xamarin_SQLite.Droid.Data
{
    public class ApplicationDbContext
    {
        readonly SQLiteAsyncConnection _database;

        public ApplicationDbContext(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Movie>().Wait();

        }
        public Task<List<Movie>> GetMovieAsync()
        {
            return _database.Table<Movie>().ToListAsync();
        }
        public Task<int> SaveMovieAsync(Movie movie)
        {
            return _database.InsertAsync(movie);
        }
    }
    
}