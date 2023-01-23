using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfHolliday
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			getData ();
		}

		public async void getData()
		{
			var tag = "us";
			var apiUrl = "https://date.nager.at/api/v2/publicholidays/2020/" + tag;
			//https://api.publicapis.org/entries

			try
			{
				using (HttpClient client = new HttpClient())
				{
					try
					{
						HttpResponseMessage response = client.GetAsync(apiUrl).Result;
						HttpContent content = response.Content;

						List<Hollydays> apiData = await response.Content.ReadFromJsonAsync<List<Hollydays>>();

						if (apiData != null)
						{

							for (var i = 0; i < apiData.Count; i++)
							{
								dataListView.Items.Add(apiData[i]);
							}
							Console.WriteLine("Data found.");
							consoleLabel.Content = "Console: Data found!";
						}
						else
						{
							Console.WriteLine("No data.");
							consoleLabel.Content = "Console: No data!";
						}
					}
					catch(Exception ex)
					{
						Console.WriteLine(ex.Message);
						consoleLabel.Content = "API is offline!";
					}
				}
			}catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
				consoleLabel.Content= "Console: Error!";
			}
			
		}

		private void dataListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			var infoData = (Hollydays)dataListView.SelectedValue;
			if (infoData != null)
			{
				var infoPage = new InfoTab(infoData);
				infoPage.Show();
			}
		}


	}
}
