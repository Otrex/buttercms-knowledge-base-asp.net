using ButterCMS.Models;
using buttercmsknowledgebase.Category;
using buttercmsknowledgebase.Models;
using buttercmsknowledgebase.SearchModel;
using buttercmsknowledgebase.Service;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace buttercmsknowledgebase.Pages;

public class CategoryModel : PageModel
{
    public string? Slug;
    public PagesResponse<KBPage>? PageData;
    public KBCategories? Categories;



    public async Task OnGetAsync()
    {
        var butterClient = AppService.GetClient();
        Slug = (string)(RouteData.Values["slug"] ?? "");
        Categories = await AppService.GetCategories();
        PageData = await butterClient.ListPagesAsync<KBPage>(
            "kb_page",
            new Dictionary<string, string>() 
            {
                {"fields.category.name", Slug},
                {"page", "1"},
                {"page_size", "10"},
            }
        );
    }
}
