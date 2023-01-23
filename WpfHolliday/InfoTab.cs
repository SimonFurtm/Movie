using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;


namespace WpfHolliday
{
	/// <summary>
	/// Interaktionslogik für infoTab.xaml
	/// </summary>
	class InfoTab : Window
	{
		public InfoTab(Hollydays hollyday)
		{

			this.Title = "Additional Information for: " + hollyday.name;
			this.Width = 200;
			this.Height = 200;

			var infoText = new TextBox();
			infoText.Text = "Datum: " + hollyday.date.ToString("MMMM dd, yyyy") +
				"\nName: " + hollyday.name +
				"\nLocal Name: " + hollyday.localName +
				"\nCountry: " + hollyday.countryCode +
				"\nFixed: " + hollyday.@fixed +
				"\nGlobal: " + hollyday.global +
				"\nCounties: " + hollyday.counties +
				"\nLaunch Year: " + hollyday.launchYear +
				"\nType: " + hollyday.type;

			this.Content= infoText;

		}


	}
}
