using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using COMP212_Xamarin_SQLite.Droid.Model;
using SQLite;

namespace COMP212_Xamarin_SQLite.Droid.Data
{
    public  class ApplicationDbContext
    {
        readonly SQLiteAsyncConnection _database;

        public ApplicationDbContext(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Movie>().Wait();

        }


    }
}