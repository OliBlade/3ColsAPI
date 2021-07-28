using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ThreeCols.Objects;

namespace ThreeCols
{
	public class ThreeColsClient
	{
		private HttpClient HttpClient { get; }

		public ThreeColsClient(string apiKey)
		{
			HttpClient = new HttpClient();
			HttpClient.BaseAddress = new Uri("https://dev.3cols.com/api/public/");
			HttpClient.DefaultRequestHeaders.Add("x-api-key", apiKey);
		}

		#region Board
		/// <summary>
		/// Returns a list of all boards to which the authenticated user has access
		/// </summary>
		public async Task<GetBoardsResponse> ListBoards()
		{
			var response = await HttpClient.GetAsync("board/list");
			response.EnsureSuccessStatusCode();

			var responseString = await response.Content.ReadAsStringAsync();
			return JsonConvert.DeserializeObject<GetBoardsResponse>(responseString);
		}

		/// <summary>
		/// Returns information about the specified board
		/// </summary>
		public async Task<Board> GetBoard(string boardID)
		{
			var response = await HttpClient.GetAsync("board/get?boardID=" + boardID);
			response.EnsureSuccessStatusCode();

			var responseString = await response.Content.ReadAsStringAsync();
			return JsonConvert.DeserializeObject<Board>(responseString);
		}
		#endregion

		#region Category
		/// <summary>
		/// Returns a list of categories based on the boardID supplied in the request
		/// </summary>
		public async Task<Category[]> ListCategories(string boardID)
		{
			var response = await HttpClient.GetAsync("category/list?boardID=" + boardID);
			response.EnsureSuccessStatusCode();

			var responseString = await response.Content.ReadAsStringAsync();
			return JsonConvert.DeserializeObject<Category[]>(responseString);
		}

		/// <summary>
		/// Returns information about the specified category
		/// </summary>
		public async Task<Category> GetCategory(int categoryID)
		{
			var response = await HttpClient.GetAsync("category/get?categoryID=" + categoryID);
			response.EnsureSuccessStatusCode();

			var responseString = await response.Content.ReadAsStringAsync();
			return JsonConvert.DeserializeObject<Category>(responseString);
		}

		/// <summary>
		/// Adds and returns a new category
		/// </summary>
		public async Task<Category> AddCategory(CategoryRequest categoryRequest)
		{
			var json = JsonConvert.SerializeObject(categoryRequest);
			var response = await HttpClient.PostAsync("category/add", new StringContent(json, Encoding.UTF8, "application/json"));
			response.EnsureSuccessStatusCode();

			var responseString = await response.Content.ReadAsStringAsync();
			return JsonConvert.DeserializeObject<Category>(responseString);
		}

		/// <summary>
		/// Updates the specified category
		/// </summary>
		public async Task UpdateCategory(Category category)
		{
			var json = JsonConvert.SerializeObject(category);
			var response = await HttpClient.PutAsync("category/update", new StringContent(json, Encoding.UTF8, "application/json"));
			response.EnsureSuccessStatusCode();
		}

		/// <summary>
		/// Deletes the specified category
		/// </summary>
		public async Task DeleteCategory(int categoryID)
		{
			var response = await HttpClient.DeleteAsync("category/delete?categoryID=" + categoryID);
			response.EnsureSuccessStatusCode();
		}
		#endregion

		#region Subcategory
		/// <summary>
		/// Returns a list of subcategories based on the categoryID supplied in the request
		/// </summary>
		public async Task<Subcategory[]> ListSubcategories(int categoryID)
		{
			var response = await HttpClient.GetAsync("subcategory/list?categoryID=" + categoryID);
			response.EnsureSuccessStatusCode();

			var responseString = await response.Content.ReadAsStringAsync();
			return JsonConvert.DeserializeObject<Subcategory[]>(responseString);
		}

		/// <summary>
		/// Returns information about the specified subcategory
		/// </summary>
		public async Task<Subcategory> GetSubcategory(int subcategoryID)
		{
			var response = await HttpClient.GetAsync("subcategory/get?subcategoryID=" + subcategoryID);
			response.EnsureSuccessStatusCode();

			var responseString = await response.Content.ReadAsStringAsync();
			return JsonConvert.DeserializeObject<Subcategory>(responseString);
		}

		/// <summary>
		/// Adds and returns a new subcategory
		/// </summary>
		public async Task<Subcategory> AddSubcategory(SubcategoryRequest subcategoryRequest)
		{
			var json = JsonConvert.SerializeObject(subcategoryRequest);
			var response = await HttpClient.PostAsync("subcategory/add", new StringContent(json, Encoding.UTF8, "application/json"));
			response.EnsureSuccessStatusCode();

			var responseString = await response.Content.ReadAsStringAsync();
			return JsonConvert.DeserializeObject<Subcategory>(responseString);
		}

		/// <summary>
		/// Updates the specified subcategory
		/// </summary>
		public async Task UpdateSubcategory(Subcategory subcategory)
		{
			var json = JsonConvert.SerializeObject(subcategory);
			var response = await HttpClient.PutAsync("subcategory/update", new StringContent(json, Encoding.UTF8, "application/json"));
			response.EnsureSuccessStatusCode();
		}

		/// <summary>
		/// Deletes the specified subcategory
		/// </summary>
		public async Task DeleteSubcategory(int subcategoryID)
		{
			var response = await HttpClient.DeleteAsync("subcategory/delete?subcategoryID=" + subcategoryID);
			response.EnsureSuccessStatusCode();
		}
		#endregion

		#region Snippet
		/// <summary>
		/// Returns a list of snippets based on the subcategoryID supplied in the request
		/// </summary>
		public async Task<Snippet[]> ListSnippets(int subcategoryID)
		{
			var response = await HttpClient.GetAsync("snippet/list?subcategoryID=" + subcategoryID);
			response.EnsureSuccessStatusCode();

			var responseString = await response.Content.ReadAsStringAsync();
			return JsonConvert.DeserializeObject<Snippet[]>(responseString);
		}

		/// <summary>
		/// Returns information about the specified snippet including its content
		/// </summary>
		public async Task<Snippet> GetSnippet(int snippetID)
		{
			var response = await HttpClient.GetAsync("snippet/get?snippetID=" + snippetID);
			response.EnsureSuccessStatusCode();

			var responseString = await response.Content.ReadAsStringAsync();
			return JsonConvert.DeserializeObject<Snippet>(responseString);
		}

		/// <summary>
		/// Adds and returns a new snippet
		/// </summary>
		public async Task<Snippet> AddSnippet(SnippetRequest snippetRequest)
		{
			var json = JsonConvert.SerializeObject(snippetRequest);
			var response = await HttpClient.PostAsync("snippet/add", new StringContent(json, Encoding.UTF8, "application/json"));
			response.EnsureSuccessStatusCode();

			var responseString = await response.Content.ReadAsStringAsync();
			return JsonConvert.DeserializeObject<Snippet>(responseString);
		}

		/// <summary>
		/// Updates the specified snippet
		/// </summary>
		public async Task UpdateSnippet(Snippet snippet)
		{
			var json = JsonConvert.SerializeObject(snippet);
			var response = await HttpClient.PutAsync("snippet/update", new StringContent(json, Encoding.UTF8, "application/json"));
			response.EnsureSuccessStatusCode();
		}

		/// <summary>
		/// Deletes the specified snippet
		/// </summary>
		public async Task DeleteSnippet(int snippetID)
		{
			var response = await HttpClient.DeleteAsync("snippet/delete?snippetID=" + snippetID);
			response.EnsureSuccessStatusCode();
		}
		#endregion
	}
}
