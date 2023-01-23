using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;


namespace WpfMovie
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			getData();
		}
		
		private async void getData()
		{
			var apiUrl = "https://localhost:7095/api";
			try
			{
				using(HttpClient client = new HttpClient())
				{
					try
					{
						HttpResponseMessage responseMessage = client.GetAsync(apiUrl).Result;
						HttpContent content= responseMessage.Content;

						List<Movie> apiData = await content.ReadFromJsonAsync<List<Movie>>();

						if (apiData != null )
						{
						//#1 for	
							/*for (var i = 0; i < apiData.Count; i++)
							{
								var movie = apiData[i];
							}*/

						//#2 foreach
							foreach (Movie movie in apiData)
							{
								dataListView.Items.Add(movie);
							}
						}
						else
						{
							consoleLabel.Content = "No data?";
						}

					}catch(Exception ex)
					{
						Console.WriteLine(ex.Message);
						consoleLabel.Content = "Console: API is not reachable";
						System.Threading.Thread.Sleep(1000);
						getData();
					}
				}

			}catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
				consoleLabel.Content= "Console: _Error";
			}

		}

		private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{

		}
	}
}
