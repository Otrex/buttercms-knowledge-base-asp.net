using ButterCMS;
using ButterCMS.Models;
using buttercmsknowledgebase.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace buttercmsknowledgebase.Pages;

public class IndexModel : PageModel
{
    public PageResponse<MyPage> PageData;
    public async Task OnGetAsync()
    {
        var Env = System.Environment.GetEnvironmentVariable("BUTTER_CMS_KEY");
        var butterClient = new ButterCMSClient(Env);
        var parameterDict = new Dictionary<string, string>(){};

        PageData = await butterClient.RetrievePageAsync<MyPage>("*", "express-utils-landing-page", parameterDict);
        System.Console.WriteLine(PageData);
    }
}
