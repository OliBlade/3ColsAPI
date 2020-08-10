using System;
using System.Collections.Generic;
using System.Text;

namespace ThreeCols.Objects
{
	public class Subcategory
	{
		public int? SubcategoryID { get; set; }
		public int CategoryID { get; set; }
		public string Name { get; set; }
		public string Language { get; set; }
	}
}
