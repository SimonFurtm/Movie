using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Windows;
using System.Windows.Controls;
using System.Net.Http.Json;
using System;

namespace WpfMovies
{
    public partial class MainWindow : Window
    {
        

        private async void GetResultAsync(){
            /*var request = (HttpWebRequest)WebRequest.Create("https://localhost:7174/api/Movies");
            var response = (HttpWebResponse)request.GetResponse();
            string responseString;
            using (var stream = response.GetResponseStream())
            {
                using (var reader = new StreamReader(stream))
                {
                    responseString = reader.ReadToEnd();
                    
                } 
            }*/
            //var movies = JsonConvert.DeserializeObject<List<Movie>>(responseString);
            try
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage responseString = await client.GetAsync("https://localhost:7174/api/Movies");
            
                List<Movie> data = await responseString.Content.ReadFromJsonAsync<List<Movie>>();

                foreach (Movie movie in data)
                {
                    MovieListView.Items.Add(movie);
                }

            }catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private void MovieListView_SelectionChanged(object sender, SelectionChangedEventArgs e){
            var window1 = new Window1();
            window1.Show();
            var selectedMovie = (Movie)MovieListView.SelectedItem;
            window1.setDataGrid(selectedMovie);

        }

        public MainWindow(){     
            InitializeComponent();

            GetResultAsync();
        }
    }
}
