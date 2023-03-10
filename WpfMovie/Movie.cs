using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Xml.Linq;

namespace WpfMovie
{
	public class Movie
	{
		public int Id { get; set; }
		public string? Title { get; set; }
		public DateTime ReleaseDate { get; set; }
		public string? Genre { get; set; }
		public decimal Price { get; set; }
		public string? Rating { get; set; }
	}
}
