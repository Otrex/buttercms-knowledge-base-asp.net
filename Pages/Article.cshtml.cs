using ButterCMS.Models;
using buttercmsknowledgebase.Category;
using buttercmsknowledgebase.Models;
using buttercmsknowledgebase.Service;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace buttercmsknowledgebase.Pages;

public class ArticleModel : PageModel
{
    public PageResponse<KBPage>? PageData;
    public KBCategories? Categories;
    public async Task OnGetAsync()
    {
        var butterClient = AppService.GetClient();
        var Slug = (string)(RouteData.Values["slug"] ?? "");
        PageData = await butterClient.RetrievePageAsync<KBPage>("kb_page",Slug);
        Categories = await AppService.GetCategories();
    }
}