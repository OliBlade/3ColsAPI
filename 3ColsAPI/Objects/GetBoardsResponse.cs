using System;
using System.Collections.Generic;
using System.Text;

namespace ThreeCols.Objects
{
	public class GetBoardsResponse
	{
		public IEnumerable<Board> ownedBoards { get; set; }
		public IEnumerable<Board> sharedBoards { get; set; }
		public IEnumerable<Board> organisationBoards { get; set; }
	}
}
