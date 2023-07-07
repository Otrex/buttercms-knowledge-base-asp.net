
namespace buttercmsknowledgebase.Models
{
    public class KBPage
    {
        public Seo Seo { get; set; }
        public KBHeader Header { get; set; }
        public string Content { get; set; }
    }

    public class KBHeader
    {
        public string Headline { get; set; }
        public string Author { get; set; }
        public string GithubLink { get; set; }
    }
    public class Header
    {
        public string? Headline { get; set; }
        public string? Sub { get; set; }
    }

    public class Card
    {
        public string? Headline { get; set; }
        public string? Sub { get; set; }
        public string? Image { get; set; }
    }

    public class Topics
    {
        public required List<Card> Cards { get; set; }
    }

    public class Featured
    {
        public string? Title { get; set; }
        public string? Link { get; set; }
    }

    public class Seo
    {
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? Description { get; set; }
    }

    public class MyPage
    {
        public string? Slug { get; set; }
        public string? Name { get; set; }
        public DateTime Published { get; set; }
        public DateTime Updated { get; set; }
        public required object PageType { get; set; }
        public required Header Header { get; set; }
        public required Topics Topics { get; set; }
        public required List<Featured> Featured { get; set; }
        public required Seo Seo { get; set; }
    }


}