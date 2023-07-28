namespace buttercmsknowledgebase.Category {

    public class IMeta {
        public int count { get; set; }
    }
  public class Meta
  {
      public int Id { get; set; }
  }

  public class KbCategory
  {
      public Meta Meta { get; set; }
      public string Name { get; set; }
      public string Icon { get; set; }
      public string Description { get; set; }
  }

  public class Data
  {
      public List<KbCategory> KbCategory { get; set; }
  }

  public class KBCategories
  {
    public IMeta meta { get; set; }
    public Data data { get; set; }
  }
}