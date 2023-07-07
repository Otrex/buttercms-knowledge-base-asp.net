using ButterCMS;
using ButterCMS.Models;
using buttercmsknowledgebase.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace buttercmsknowledgebase.Pages;

public class SearchModel : PageModel
{
    public PagesResponse<MyPage> PageData;

    public async Task OnGetAsync()
    {
        using (var client = new HttpClient())
        {
            var query = HttpContext.Request.Query["q"].FirstOrDefault() ?? "*";
            var env = Environment.GetEnvironmentVariable("BUTTER_CMS_KEY");
            try {
                string url = $"https://api.buttercms.com/v2/pages/search/?query={query}&auth_token={env}";
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                PageData = JsonConvert.DeserializeObject<PagesResponse<MyPage>>(responseBody);
            } catch (HttpRequestException ex) {}
        }
    }
}

