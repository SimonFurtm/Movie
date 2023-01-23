using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;


namespace WpfUni
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
			var country = "austria";
			var apiUrl = "http://universities.hipolabs.com/search?country=" + country;
			try
			{
				//using (x wird nur im using verwendet){...}
				using (HttpClient Client = new HttpClient())
				{
					try
					{
						using (HttpResponseMessage response = await Client.GetAsync(apiUrl))
						{
							HttpContent content = response.Content;

							List<Universities> apiData = await response.Content.ReadFromJsonAsync<List<Universities>>();

							if(apiData!= null)
							{
								
								for(int i = 0; i < apiData.Count; i++)
								{
									dataListView.Items.Add(apiData[i]);
								}
								Console.WriteLine("Data Found.");
								consoleLabel.Content = "Console: Data found!";
							}
							else
							{
								Console.WriteLine("No Data?");
								consoleLabel.Content = "Console: No Data?";
							}
						}
							
					}catch(Exception ex)
					{
						Console.WriteLine(ex.Message);
						consoleLabel.Content = "Console: API offline!";
						System.Threading.Thread.Sleep(1000);
						getData();
					}
				}

			}catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
				consoleLabel.Content= ex.StackTrace;
			}
			
		
		}

		private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			var selectedUni = (Universities)dataListView.SelectedValue;

			if(selectedUni!=null)
			{
				var infoWindow = new InfoScreen(selectedUni);
				infoWindow.Show();
			}
		}

		private void countryComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
		{
			
		}
	}
}
