using COMP212_Xamarin_SQLite.Droid.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace COMP212_Xamarin_SQLite
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        public async void AddMovieToDB()
        {
            if (string.IsNullOrEmpty(movieTitle.Text))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                     "Please Enter Movie Name !",
                     "Accept"
                    );
                return;
            }
            if (string.IsNullOrEmpty(movieGenre.Text))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                     "What is the movie genre ?",
                     "Accept"
                    );
                return;
            }
            var movie = new Movie
            {
                Title = movieTitle.Text,
                Genre = movieGenre.Text,
                Release_Date = release_Date.Date
            };

            await App.ApplicationDbContext.SaveMovieAsync(movie);
        }
        private void btnSave_Clicked(object sender, EventArgs e)
        {
           AddMovieToDB();
            ClearFields();
           Application.Current.MainPage.DisplayAlert(
                     "Succes !",
                      "Information Stored Successfuly",
                      "Ok"
                     );
            return;
        }


        private void btnView_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MovieListView());
        }

        public void ClearFields()
        {
            movieTitle.Text = null;
            movieGenre.Text = null;
            
        }
    }
}
