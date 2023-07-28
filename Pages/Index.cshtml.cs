using ButterCMS.Models;
using buttercmsknowledgebase.Models;
using buttercmsknowledgebase.Service;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace buttercmsknowledgebase.Pages;
public class IndexModel : PageModel
{
    public PageResponse<LandingPage>? PageData;
    public async Task OnGetAsync()
    {
        var butterClient = AppService.GetClient();
        PageData = await butterClient.RetrievePageAsync<LandingPage>("*", "express-utils-knowledge-base");
    }
}
