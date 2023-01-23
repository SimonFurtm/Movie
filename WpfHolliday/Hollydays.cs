using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfHolliday
{
	internal class Hollydays
	{
		public DateTime date { get; set; }
		public string localName { get; set; }
		public string name { get; set; }
		public string countryCode { get; set; }
		public bool @fixed { get; set; }
		public bool global { get; set; }
		public object counties { get; set; }
		public int? launchYear { get; set; }
		public string type { get; set; }
	}
}
