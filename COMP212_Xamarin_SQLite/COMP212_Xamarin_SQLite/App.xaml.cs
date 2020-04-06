using COMP212_Xamarin_SQLite.Droid.Data;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace COMP212_Xamarin_SQLite
{
    public partial class App : Application
    {
        static ApplicationDbContext db;

        public static ApplicationDbContext ApplicationDbContext
        {
            get
            {
                if (db==null)
                {
                    db = new ApplicationDbContext(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "movie.db3"));
                }
                return db;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage( new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
