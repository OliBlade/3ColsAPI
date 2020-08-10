using System;
using System.Collections.Generic;
using System.Text;

namespace ThreeCols.Objects
{
	public class Snippet
	{
		public int? SnippetID { get; set; }
		public int SubcategoryID { get; set; }
		public string Name { get; set; }
		public string Content { get; set; }
		public string Language { get; set; }
	}
}
