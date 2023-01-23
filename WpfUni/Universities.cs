using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfUni
{
    class Universities
	{
		public List<string> websites { get; set; }

		//[JsonProperty("state-province")]
		public object stateprovince { get; set; }
		public string alpha_two_code { get; set; }
		public string name { get; set; }
		public string country { get; set; }
		public List<string> domains { get; set; }
	}
}
