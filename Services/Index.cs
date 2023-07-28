using ButterCMS;
using buttercmsknowledgebase.Category;
using buttercmsknowledgebase.SearchModel;
using Newtonsoft.Json;

namespace buttercmsknowledgebase.Service
{
    public class AppService
    {
        public static ButterCMSClient GetClient()
        {
            var Env = System.Environment.GetEnvironmentVariable("BUTTER_CMS_KEY");
            return new ButterCMSClient(Env);
        }

        public static async Task<KBCategories> GetCategories() 
        {
          var client = AppService.GetClient();
          var contentFields = await client.RetrieveContentFieldsJSONAsync(
            new string[1] { "kbcategory" }
          );
          return JsonConvert.DeserializeObject<KBCategories>(contentFields);
        }

        public static async Task<SearchResult> SearchKBPages(string query) 
        {
          using (var client = new HttpClient())
          {
            var env = Environment.GetEnvironmentVariable("BUTTER_CMS_KEY");
            string url = $"https://api.buttercms.com/v2/pages/search/?query={query}&page_type=kb_page&auth_token={env}";
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            System.Console.WriteLine(responseBody);
            return JsonConvert.DeserializeObject<SearchResult>(responseBody);
          }
        }
    }
}