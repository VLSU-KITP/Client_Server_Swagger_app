using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MyRazorApp.Pages
{
    public class DataModel : PageModel
    {
        private readonly HttpClient _httpClient;

        public DataModel(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public List<string> Data { get; set; }

        public async Task OnGetAsync()
        {
            var response = await _httpClient.GetStringAsync("https://localhost:5001/api/api/data");
            Data = JsonConvert.DeserializeObject<List<string>>(response);
        }
    }
}
