using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using Newtonsoft.Json;


namespace WpfMovies
{
    public partial class MainWindow : Window
    {

        private void GetResultAsync(){
            var request = (HttpWebRequest)WebRequest.Create("https://localhost:7174/api/Movies");
            var response = (HttpWebResponse)request.GetResponse();
            string responseString;
            using (var stream = response.GetResponseStream())
            {
                using (var reader = new StreamReader(stream))
                {
                    responseString = reader.ReadToEnd();
                    
                } 
            }
            var movies = JsonConvert.DeserializeObject<List<Movie>>(responseString);
            if (movies != null)
            {
                for (int i = 0; i < movies.Count; i++)
                {
                    MovieListView.Items.Add(movies[i]);
                }
            }
        }

        private void MovieListView_SelectionChanged(object sender, SelectionChangedEventArgs e){
            var selectedMovie = (Movie)MovieListView.SelectedItem;

            if (selectedMovie != null) 
            {
                // Show additional information in a popup window
                var movieInfoPopup = new MovieInfoPopup(selectedMovie);
                movieInfoPopup.Show();
            }

        }

        public MainWindow(){     
            InitializeComponent();
            GetResultAsync();
        }
    }
}
