using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;

namespace COMP212_Xamarin_SQLite.Droid.Model
{
   public class Movie
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public DateTime Release_Date { get; set; }

    }
}