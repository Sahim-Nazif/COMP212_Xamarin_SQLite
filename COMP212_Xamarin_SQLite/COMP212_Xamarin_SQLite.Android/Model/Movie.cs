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