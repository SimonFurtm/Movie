using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMattl
{
	class Movie
	{
		public int Id { get; set; }
		public string? Title { get; set; }
		public DateTime ReleaseDate { get; set; }
		public decimal Price { get; set; }
		public string? Genre { get; set; }
		public string? Rating { get; set; }
	}
}