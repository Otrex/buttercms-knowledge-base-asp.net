using buttercmsknowledgebase.Category;
using buttercmsknowledgebase.SearchModel;
using buttercmsknowledgebase.Service;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace buttercmsknowledgebase.Pages;

public class SearchModel : PageModel
{
    public SearchResult? PageData;
    public KBCategories? Categories;
    public async Task OnGetAsync()
    {
        Categories = await AppService.GetCategories();
        PageData = await AppService.SearchKBPages(
            HttpContext.Request.Query["q"].FirstOrDefault() ?? "*"
        );
    }
}
