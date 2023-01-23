using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfUni
{
    class InfoScreen : Window
	{
		public InfoScreen(Universities universitie)
		{
			// Set the title of the popup window
			this.Title = "Additional Information: " + universitie.name;
			this.Width = 400;
			this.Height = 200;

			// Create a TextBlock to display the additional information
			var uniInfoTextBlock = new TextBlock();
			uniInfoTextBlock.Text = "Name: " + universitie.name + "\n" + 
									"Staat: " + universitie.stateprovince + "\n" +
									"Alpha2Code: " + universitie.alpha_two_code + "\n" +
									"Country: " + universitie.country + "\n" +
									"Websites: " + universitie.websites + "\n" + 
									"Domains: " + string.Join(", ", universitie.domains) + "\n"; //Array

			// Add the TextBlock to the popup window's content
			this.Content = uniInfoTextBlock;
		}
	}
}
