using ButterCMS.Models;
using Newtonsoft.Json;

namespace buttercmsknowledgebase.SearchModel {
  // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Contact
    {
        [JsonProperty("headline")]
        public string Headline { get; set; }

        [JsonProperty("sub")]
        public string Sub { get; set; }

        [JsonProperty("contactlink")]
        public string Contactlink { get; set; }
    }

    public class Datum
    {
        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("published")]
        public DateTime Published { get; set; }

        [JsonProperty("updated")]
        public DateTime Updated { get; set; }

        [JsonProperty("page_type")]
        public string PageType { get; set; }

        [JsonProperty("fields")]
        public Fields Fields { get; set; }
    }

    public class Featured
    {
        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("published")]
        public DateTime Published { get; set; }

        [JsonProperty("updated")]
        public DateTime Updated { get; set; }

        [JsonProperty("page_type")]
        public string PageType { get; set; }

        [JsonProperty("fields")]
        public Fields Fields { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class Fields
    {
        [JsonProperty("seo")]
        public Seo Seo { get; set; }

        [JsonProperty("header")]
        public Header Header { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("topics")]
        public object Topics { get; set; }

        [JsonProperty("contact")]
        public Contact Contact { get; set; }

        [JsonProperty("featured")]
        public List<Featured> Featured { get; set; }
    }

    public class Header
    {
        [JsonProperty("headline")]
        public string Headline { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("githublink")]
        public string Githublink { get; set; }

        [JsonProperty("sub")]
        public string Sub { get; set; }
    }

    public class Meta
    {
        [JsonProperty("next_page")]
        public object NextPage { get; set; }

        [JsonProperty("previous_page")]
        public object PreviousPage { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class SearchResult
    {
        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("data")]
        public List<Datum> Data { get; set; }
  }

    public class Seo
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }
    }


}