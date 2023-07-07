using ButterCMS;
using ButterCMS.Models;
using buttercmsknowledgebase.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace buttercmsknowledgebase.Pages;

public class ArticleModel : PageModel
{
    public PageResponse<KBPage> PageData;
    public async Task OnGetAsync()
    {
        var Slug = (string)RouteData.Values["slug"];
        var Env = System.Environment.GetEnvironmentVariable("BUTTER_CMS_KEY");
        var butterClient = new ButterCMSClient(Env);
        var parameterDict = new Dictionary<string, string>(){};
        PageData = await butterClient.RetrievePageAsync<KBPage>("*",Slug,parameterDict);
    }
}