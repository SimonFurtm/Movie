using System.Windows.Controls;
using System.Windows;

using WpfMattl;

class MovieInfoPopup : Window
{
	public MovieInfoPopup(Movie selectedMovie)
	{
		// Set the title of the popup window
		this.Title = "Additional Information: " + selectedMovie.Title;
		this.Width = 400;
		this.Height = 200;

		// Create a TextBlock to display the additional information
		var movieInfoTextBlock = new TextBlock();
		movieInfoTextBlock.Text = "Release Date: " + selectedMovie.ReleaseDate + "\n" +
								  "Price: " + selectedMovie.Price + "\n" +
								  "Genre: " + selectedMovie.Genre + "\n" +
								  "Rating: " + selectedMovie.Rating;

		// Add the TextBlock to the popup window's content
		this.Content = movieInfoTextBlock;
	}
}
