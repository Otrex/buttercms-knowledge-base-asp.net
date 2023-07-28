
namespace buttercmsknowledgebase.Models
{
    public class IMeta
    {
        public object NextPage { get; set; }

        public object PreviousPage { get; set; }

        public int Count { get; set; }
    }
    public class Meta
    {
        public int Id { get; set; }
    }
    public class Header
    {
        public string Headline { get; set; }
        public string Sub { get; set; }
        public string Author { get; set; }
        public string GithubLink { get; set; }
    }

    public class Seo
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
    }

    public class Category
    {
        public Meta Meta { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
    }

    public class KBPage
    {
        public string Slug { get; set; }
        public string Name { get; set; }
        public DateTime Published { get; set; }
        public DateTime Updated { get; set; }
        public string PageType { get; set; }
        public Seo Seo { get; set; }
        public Header Header { get; set; }
        public string Content { get; set; }
        public List<Category> Category { get; set; }
    }

    public class SearchKBPages
    {
        public IMeta Meta { get; set; }
        public List<KBPage> Data { get; set;}
    }

    public class Contact
    {
        public string Headline { get; set; }
        public string Sub { get; set; }
        public string ContactLink { get; set; }
    }

    public class LandingPage
    {
        public string? Slug { get; set; }
        public string? Name { get; set; }
        public DateTime Published { get; set; }
        public DateTime Updated { get; set; }
        public required object PageType { get; set; }
        public required Header Header { get; set; }
        public required List<Category> Topics { get; set; }
        public required List<KBPage> Features { get; set; }
        public required Seo Seo { get; set; }
        public required Contact Contact { get; set; }
    }

}