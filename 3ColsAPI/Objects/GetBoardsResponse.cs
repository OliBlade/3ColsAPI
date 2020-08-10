using System;
using System.Collections.Generic;
using System.Text;

namespace ThreeCols.Objects
{
	public class GetBoardsResponse
	{
		public IEnumerable<Board> OwnedBoards { get; set; }
		public IEnumerable<Board> SharedBoards { get; set; }
		public IEnumerable<Board> OrganisationBoards { get; set; }
	}
}
